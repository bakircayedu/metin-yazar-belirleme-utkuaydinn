using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetinYazariBelirleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack stack = new Stack();
        int a = 0;
        Stack stackKelime = new Stack();
        Heap heap = new Heap(500);
        string[] kelimelerVeAdetler = new string[1000];
        int h = 0;
        int g = 0;
        int c = 0;
        int b = 0;
        Hashtable hashKelimeler = new Hashtable(); 
        List<string> adet = new List<string>();

        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            openFileDialogMetin.ShowDialog();
            string filename = openFileDialogMetin.FileName;
            string readfile = File.ReadAllText(filename);
            richTextBoxMetin.Text = readfile;
            textBoxUzanti.Text = filename;
        }

        private void btnStackOku_Click(object sender, EventArgs e)
        {
            //Metni cümlelere bölüp stack içerisine atıyor.
            //Üzerinde işlem yapılacak metin stringini noktalama işaretlerinden ve büyük harflerden arındırıyor.
            char[] metinkesit = { '\n' };
            string metin = richTextBoxMetin.Text;
            metin = metin.ToLower();
            metin = metin.Replace("," , "").Replace(":" , "").Replace("'" , "").Replace(";", "").Replace(".", "").Replace("?", "");
            string[] cumleler = metin.Split(metinkesit);

            for (int i = 0; i < (cumleler.Length-1); i++)
            {
                stack.Push(cumleler[i]);
            }

            
            //Her cümleyi kelimelerine ayırır, bunları kelimeler içinde tutar ve kelimeleri sayarak her cümlenin kaç kelimesi olduğunu bulur.
            //'a-l' son değerden bir önceki değeri çıkartarak son cümlenin kelime sayısını buluyor
            char[] cumlekesit = { ' ' };
            string[] kelimeler = new string[1000];
            int[] kelimesayilari = new int[1000];
            int l = 0;
            for (int i = 0; i < (cumleler.Length); i++)
            {
                string[] temp = cumleler[i].Split(cumlekesit);
                foreach (var item in temp)
                {
                    kelimeler[a] = item;
                    stackKelime.Push(item);
                    a++;
                }
               kelimesayilari[i] = a - l;
                l = a;
            }

            //Dizi içerisine alınan satır başı kelimelerinin richtextbox sebebiyle aldığı boşluğu kaldırıyor.
            for (int i = 0; i < a; i++)
            {
                kelimeler[i] = kelimeler[i].Replace("\n", "");
            }

            //Ortalama kelime sayısı
            int ortalamaKelime = (a/(cumleler.Length));

            //özellikleri richtextbox'a yazdırma
             richTextBoxOzellikler.Text = "Toplam Cümle Sayısı: " + (cumleler.Length) + "\n" + "Ortalama Kelime Sayısı: " + ortalamaKelime + "\n";
            int y = 1;
            for (int t = 0; t < (cumleler.Length); t++)
            {
                 richTextBoxOzellikler.Text = richTextBoxOzellikler.Text + y + ". Cümlenin Kelime Sayısı: " + kelimesayilari[t] + "\n";
                 y++;
            }

            
            //kelimeleri tekrarsız bir biçimde yeni bir liste içerisinde tutuyor.
            for (int i = 0; i < a; i++)
            {
                if (adet.Contains(kelimeler[i]) == false)
                {
                    adet.Add(kelimeler[i]);
                }
            }

            //tekrarsız liste içerisinden kelimeleri seçerek kelimeler dizisinden bu kelimeleri saydırıp. ''Kelime Adedi'' şeklinde bir dizide tutuyor.
            foreach (string z in adet)
            {
                string degis;
                int sayac = 0;
                for (int i = 0; i < a; i++)
                {
                    if (kelimeler[i] == z)
                    {
                        sayac++;
                    }
                }
                degis = z + " " + sayac;
                kelimelerVeAdetler[h] = degis;
                h++;
            }
        }

        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {
            //Kelimelerin ve adetlerinin bir arada tutulduğu diziden bu kelimelerin sadece adetlerini ayrıştırıp sıralı indislerde tutuyor.
            char[] adetkesit = { ' ' };
            string[] kelimeAdet = new string[1000];
            for (int i = 0; i < h; i++)
            {
                string[] degisken = kelimelerVeAdetler[i].Split(adetkesit);
                foreach (var point in degisken)
                {
                    kelimeAdet[g] = point;
                    g++;
                }  
            }

            //çift sayılı indislerde kelimeler, tek sayılı indislerde adetler tutuluyor. ayrıştırılan adetleri mod ile doğrulayarak heap içerisine atıyor.
            for (int u = 0; u < g; u++)
            {
                if ( (u % 2) == 1 )
                {
                    int temp = Convert.ToInt32(kelimeAdet[u]);
                    heap.Add(temp);
                } 
            }
        }

        private void btnSikKullan_Click(object sender, EventArgs e)
        {
            
            int kullanilanAdet = Convert.ToInt32(txtSikKullan.Text);
            string[] sadeceKelimeler = new string[50000];
            string[] tekilKelimeVeAdet = new string[1000];
            int s = 0;

            char[] kes = { ' ' };
            string[] kelimevAdet = new string[1000];
            for (int i = 0; i < h; i++)
            {
                string[] degisken = kelimelerVeAdetler[i].Split(kes);
                foreach (var tem in degisken)
                {
                    kelimevAdet[c] = tem;
                    c++;
                }
            }
            //kelimelerin ve adetlerinin bulunduğu dizide tek sayılı indisler ile maxHeap yapısının root değeri karşılaştırılıyor.
            //Eşleşen değerlerin 1 indis öncesindeki kelimeler bir dizide tutuluyor.
            foreach (var itemzs in adet)
            {
                for (int i = 0; i < c; i++)
                {
                    if (itemzs == kelimevAdet[i])
                    {
                        int f = i + 1;
                        int g = s + 1;
                        tekilKelimeVeAdet[s] = itemzs;
                        tekilKelimeVeAdet[g] = kelimevAdet[f];
                        s = s + 2;
                        break;
                    }
                }
            }

            //Heap içerisindeki root değeri bir önceki peek değerine eşit değilse bu peek değerindeki 'int' deger kadar kullanılmış yani sık kullanılanlar sırasının başındaki elemanları bir diziye atıyor.
            //Her peek değerini karşılayan en az 1 değer olacağı için maksimum bizden kaç kelime döndürülmesi isteniyorsa döngü de o kadar dönüyor.
            int anliks = 0;

            for (int n = 0; n < kullanilanAdet; n++)
            {
                for (int i = 0; i < c; i++)
                {
                    if ( ( i % 2) == 1 )
                    {
                        if (anliks != heap.Peek())
                        {
                            if (Convert.ToInt32(tekilKelimeVeAdet[i]) == heap.Peek())
                            {
                                int an = (i - 1);
                                sadeceKelimeler[b] = tekilKelimeVeAdet[an];
                                b++;
                            }
                        }
                    }
                }
                anliks =heap.Pop();
            }

            
            //ekrana getirilmek istenen değer kadar heap ağacındaki root değerlerle eşleşen kelimeler bir dizide tutulmuştu.
            //Bu değerlerin textbox içine girilen değer neyse baştan itibaren o değer kadarı getiriliyor.
            string sikKullanilanlar = "";

            for (int i = 0; i < kullanilanAdet; i++)
            {
                int sayalim = i + 1;
                string tempp = sayalim + ". Kelime: " + sadeceKelimeler[i] + "\n";
                sikKullanilanlar = sikKullanilanlar + tempp;
            }

            richTextBoxSikKullan.Text = sikKullanilanlar;



        }

        private void btnHashTabloOlustur_Click(object sender, EventArgs e)
        {
            //Kelimelerin tekil olarak tutulduğu listenin elemanlarını bir diziye atadık.
            //Bunları for döngüsünün döngü sayacını stringe çevirip anahtar şeklinde kullanarak indisleyip hash tablosunu oluşturduk.

            string[] Kelimess = new string[1000];
            int v = 0;
            foreach (var itemz in adet)
            {
                Kelimess[v] = itemz;
                v++;
            }
            
            for (int i = 0; i < v; i++)
            {
                string tempss = Convert.ToString(i);
                hashKelimeler.Add(tempss,Kelimess[i]);
            }
        }
    }
}
