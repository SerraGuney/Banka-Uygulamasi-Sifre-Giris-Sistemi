using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;
namespace Bankacilik_sifre_giris_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //butonlarda tutacaðýmýz sayilarin listesini oluþturarak listeye sayilari ekledik.
            for (int i = 0; i < 10; i++)
            {
                sayilar.Add(i);
            }
        }
        List<int> sayilar = new List<int>();
        Random random = new Random();
        //random oluþturduðumuz sayilar listesinin index deðerini tutar.
        int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            //ekrana gelecek 10 adet butonun özelliklerini belirledik.
            int buttonSize = 50; 
            int butonlarArasiBosluk = 10; 
            int satýrdakiButonSayisi = 4; 
            int baslangicX = 200; 
            int baslangicY = 200; 
            
            //oluþturacaðýmýz butonlarý bir dizide tuttuk böylece sayilari rastgele butonlara atayabildik.
            Button[] buttons = new Button[10];
            for (int i = 0; i < 10; i++)
            {
                //10 adet buton oluþturduk.
                Button btn = new Button();
                //ilk deðerleini butonlara tadýk.
                btn.Text = i.ToString();
                btn.Size = new Size(buttonSize, buttonSize);
                btn.ForeColor = Color.White;
                // Satýr numarasý, Sütun numarasý
                int satir = i / satýrdakiButonSayisi; 
                int sutun = i % satýrdakiButonSayisi;
                // X koordinatý, Y koordinatý
                int x = baslangicX + sutun * (buttonSize + butonlarArasiBosluk); 
                int y = baslangicY + satir * (buttonSize + butonlarArasiBosluk); 
                btn.Location = new Point(x, y);

                //sayilar listesinin boyutunu tutuyor.
                int boyut = sayilar.Count;

                // bir butona týklandýðýnda gerçekleþecek olaylarý buraya yazdýk yani bir butona týklayýnca sayilar rastgele butona atanacak.
                btn.Click += (s, ev) =>
                {
                    //týkladýðýmýz butonun text'i textBox'a atanacak.
                    txtSifreGiris.Text += " " + btn.Text;
                    //textBox'a girilen karakter sayýsý 4 ten büyükse textBox'in içi sýfýrlanacak.
                    if (txtSifreGiris.Text.Length >= 10)
                    {
                        txtSifreGiris.Text = " ";
                        MessageBox.Show("Porolaniz 4 hanelidir.", "Uyari", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        do
                        {
                            //rastgele sayilar liste'sinin boyutu ile 0 arasýnda bir index oluþturulacak.
                            index = random.Next(0, boyut);

                            //butonlarýn text'ine sayýlar yazýldý.
                            buttons[i].Text = sayilar[index].ToString();

                            //sayilar listesinde o anada kullanýlan sayinin bir daha kullanýlmamasý için listeden o sayýyý kadýrdýk.
                            sayilar.Remove(sayilar[index]);

                            //sayiyi kaldýrýnca boyut deðerini bir azalltýk.
                            boyut--;

                            //butonlara ayný sayýlar deðeri gelmesin diye buton i'yi 1 arttýrdýk.
                            i++;

                            //boyut deðerimiz 0 dan farklý olduðu sürece çalýþýcak taki listemizin içinde sayi kalmayana kadar.
                        } while (boyut != 0);

                        //sýfýrlanan listemize tekrar sayilari ekledik.
                        for (int j = 0; j < 10; j++)
                        {
                            sayilar.Add(j);
                            boyut = sayilar.Count;
                        }
                    }
                };
                //bu butonlara daha sonra kolayca eriþebilmek ve üzerlerinde iþlem yapabilmek için Her bir butonun referansýný diziye ekledik.
                buttons[i] = btn;
                // Oluþturulan butonlarý forma ekler.
                this.Controls.Add(btn);
            }
        }       
    }
}
