using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelInter = Microsoft.Office.Interop.Excel;
using System.IO;
using Excel;

namespace Szukaj_pacjenta
{
    public partial class Form1 : Form
    {
        DataSet wynik;
        bool CzyZaładowanoPlik = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() {
                Filter = "Pliki Excel (*.xls)|*.xls|Pliki Excel (*.xlsx)|*.xlsx", FilterIndex = 2})
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CzyZaładowanoPlik = true;
                        UtwórzBazęZplikuExcel(openFile);

                        cboArkusze.Items.Clear();       // wyczyść listę wyboru arkuszy

                        UzupełnijListęWyboruArkuszy();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Nie można otworzyć pliku poniewaqż jest otwarty\n" + ex.Message);
                    }
                    
                }
            }
        }
        /// <summary>
        /// Uzupełni listę w której można wybrać arkusz do wyświetlania w datagridView
        /// </summary>
        private void UzupełnijListęWyboruArkuszy()
        {
            foreach (DataTable dt in wynik.Tables)
            {
                cboArkusze.Items.Add(dt.TableName);
            }
        }
        /// <summary>
        /// Używa biblioteki ExcelDataREader do pobrania danych z pliku Excela do obiektu DataSet
        /// </summary>
        /// <param name="openFile">openFileDialog potrzebny do określenia rodzaju wybranego filtra i w zależności od niego zastosowano rodzaj pobierania danych</param>
        private void UtwórzBazęZplikuExcel(OpenFileDialog openFile)
        {
            FileStream fs = File.Open(openFile.FileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader czytajExcela;
            if (openFile.FilterIndex == 1)
                czytajExcela = ExcelReaderFactory.CreateBinaryReader(fs);
            else
                czytajExcela = ExcelReaderFactory.CreateOpenXmlReader(fs);
            czytajExcela.IsFirstRowAsColumnNames = true;
            wynik = czytajExcela.AsDataSet();
            czytajExcela.Close();
        }
        /// <summary>
        /// Zdarzenie po zmianie arkusza z listy, zmieniamy tabelę do wyświetlenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboArkusze_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wynik.Tables[cboArkusze.SelectedIndex]; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GłównaMetoda();
        }
        private void GłównaMetoda()
        {
            List<EnumerableRowCollection<DataRow>> listaWierszy = new List<EnumerableRowCollection<DataRow>>();
            List<DataTable> tabele = new List<DataTable>();
            double nrPesel;

            if(double.TryParse(textBox_pesel.Text, out nrPesel))
            {
                PobierzNazwyArkuszy(tabele);
                tabele.RemoveAt(0); // w tej wersji usuń pierwszy arkusz, ponieważ nie jest do sprawdzania danych

                WyfiltrujDaneWgPesel(tabele, listaWierszy, nrPesel);

                rtbox_wyfiltrowaneDane.Clear(); // wyszyć dane z richtextbox
                try
                {
                    lbl_danePacjenta.Text = "Pacjent " + listaWierszy.ElementAt(1).First().ItemArray.ElementAt(1) + " był na badaniach:";
                    rtbox_wyfiltrowaneDane.AppendText("Pacjent " + listaWierszy.ElementAt(1).First().ItemArray.ElementAt(1) + " był na badaniach:\n");
                }
                catch (Exception)
                {
                    lbl_danePacjenta.Text = "Brak pacjenta w bazie lub błędny pesel";

                }
                
                

                WypiszDaneObadaniach(listaWierszy);
            }

           
        }

        /// <summary>
        /// Pobiera nazwy wszystkich arkuszy zawartych w pliku Excela
        /// </summary>
        /// <param name="tabele">Przekazana lista do uzupełnienia o nazwy arkuszy</param>
        private void PobierzNazwyArkuszy(List<DataTable> tabele)
        {
            foreach (DataTable nazwyArkuszy in wynik.Tables)
            {
                tabele.Add(nazwyArkuszy);
            }
        }
        /// <summary>
        /// Filtruje dane za pomocą Linq i dodaje wiersze do listy 
        /// </summary>
        /// <param name="tabele"></param>
        /// <param name="listaWierszy"></param>
        private static void WyfiltrujDaneWgPesel(List<DataTable> tabele, List<EnumerableRowCollection<DataRow>> listaWierszy, double nrPesel)
        {
            foreach (DataTable dt in tabele)
            {
                EnumerableRowCollection<DataRow> wiersz = from dane in dt.AsEnumerable()
                                                          where dane.Field<double>(0) == nrPesel
                                                          select dane;
                listaWierszy.Add(wiersz);
            }
        }

        private void WypiszDaneObadaniach(List<EnumerableRowCollection<DataRow>> listaWierszy)
        {
            for (int i = 0; i < listaWierszy.Count; i++)
            {
                foreach (var item in listaWierszy.ElementAt(i))
                {
                    rtbox_wyfiltrowaneDane.AppendText(item.ItemArray.ElementAt(2).ToString().Substring(1, 10) + " nr badania: " + item.ItemArray.ElementAt(4) + "\n");
                }
            }
        }
        private void opisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pierwszą rzeczą jest wskazanie bazy z pliku excela. Wgrywanie bazy w zależności od pliku może trochę trwać.\nNastępnie można w rozwijanej liście obejrzeć dane wg lat.\nAby poszukać po numerze pesel należe tenże numer wprowadzić do okna textBox i nacisnąć przycisk enter lub wcisnąć guzik szukaj...", "Krótki opis");
        }

        private void textBox_pesel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GłównaMetoda();
            }
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacja darmowa przygotowana przez:\nKamil Pawłowski\nPiotr Pawłowski", "Autorzy");
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
