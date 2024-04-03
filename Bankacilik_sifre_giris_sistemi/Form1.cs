using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;
namespace Bankacilik_sifre_giris_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //butonlarda tutaca��m�z sayilarin listesini olu�turarak listeye sayilari ekledik.
            for (int i = 0; i < 10; i++)
            {
                sayilar.Add(i);
            }
        }
        List<int> sayilar = new List<int>();
        Random random = new Random();
        //random olu�turdu�umuz sayilar listesinin index de�erini tutar.
        int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            //ekrana gelecek 10 adet butonun �zelliklerini belirledik.
            int buttonSize = 50; 
            int butonlarArasiBosluk = 10; 
            int sat�rdakiButonSayisi = 4; 
            int baslangicX = 200; 
            int baslangicY = 200; 
            
            //olu�turaca��m�z butonlar� bir dizide tuttuk b�ylece sayilari rastgele butonlara atayabildik.
            Button[] buttons = new Button[10];
            for (int i = 0; i < 10; i++)
            {
                //10 adet buton olu�turduk.
                Button btn = new Button();
                //ilk de�erleini butonlara tad�k.
                btn.Text = i.ToString();
                btn.Size = new Size(buttonSize, buttonSize);
                btn.ForeColor = Color.White;
                // Sat�r numaras�, S�tun numaras�
                int satir = i / sat�rdakiButonSayisi; 
                int sutun = i % sat�rdakiButonSayisi;
                // X koordinat�, Y koordinat�
                int x = baslangicX + sutun * (buttonSize + butonlarArasiBosluk); 
                int y = baslangicY + satir * (buttonSize + butonlarArasiBosluk); 
                btn.Location = new Point(x, y);

                //sayilar listesinin boyutunu tutuyor.
                int boyut = sayilar.Count;

                // bir butona t�kland���nda ger�ekle�ecek olaylar� buraya yazd�k yani bir butona t�klay�nca sayilar rastgele butona atanacak.
                btn.Click += (s, ev) =>
                {
                    //t�klad���m�z butonun text'i textBox'a atanacak.
                    txtSifreGiris.Text += " " + btn.Text;
                    //textBox'a girilen karakter say�s� 4 ten b�y�kse textBox'in i�i s�f�rlanacak.
                    if (txtSifreGiris.Text.Length >= 10)
                    {
                        txtSifreGiris.Text = " ";
                        MessageBox.Show("Porolaniz 4 hanelidir.", "Uyari", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        do
                        {
                            //rastgele sayilar liste'sinin boyutu ile 0 aras�nda bir index olu�turulacak.
                            index = random.Next(0, boyut);

                            //butonlar�n text'ine say�lar yaz�ld�.
                            buttons[i].Text = sayilar[index].ToString();

                            //sayilar listesinde o anada kullan�lan sayinin bir daha kullan�lmamas� i�in listeden o say�y� kad�rd�k.
                            sayilar.Remove(sayilar[index]);

                            //sayiyi kald�r�nca boyut de�erini bir azallt�k.
                            boyut--;

                            //butonlara ayn� say�lar de�eri gelmesin diye buton i'yi 1 artt�rd�k.
                            i++;

                            //boyut de�erimiz 0 dan farkl� oldu�u s�rece �al���cak taki listemizin i�inde sayi kalmayana kadar.
                        } while (boyut != 0);

                        //s�f�rlanan listemize tekrar sayilari ekledik.
                        for (int j = 0; j < 10; j++)
                        {
                            sayilar.Add(j);
                            boyut = sayilar.Count;
                        }
                    }
                };
                //bu butonlara daha sonra kolayca eri�ebilmek ve �zerlerinde i�lem yapabilmek i�in Her bir butonun referans�n� diziye ekledik.
                buttons[i] = btn;
                // Olu�turulan butonlar� forma ekler.
                this.Controls.Add(btn);
            }
        }       
    }
}
