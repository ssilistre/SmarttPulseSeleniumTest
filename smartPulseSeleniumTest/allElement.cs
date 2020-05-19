using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartPulseSeleniumTest
{
    class allElement
    {
        public static string url="https://seffaflik.epias.com.tr/transparency/";
        public static string uretimMenu = "menuform:rm_orientation2";
        public static string planlamaMenu = "menuform:j_idt59";
        public static string kgupXpath= "//*[@id='menuform:j_idt60'][1]";

        /////////////////////////// KGÜP Sayafası Elementleri /////////
        ///

        public static string uygulabutton = "j_idt202:goster";
        public static string baslangicTarih = "//*[@id='j_idt202:date1_input']";
        public static string bitisTarih = "//*[@id='j_idt202:date2_input']";
        public static string excelImageid = "j_idt202:dt:j_idt252";

        ///Seçilecek Tarihler
        ///

        public static string AySec = "ui-datepicker-month";
        public static string Mart = "//*[@class='ui-datepicker-month'][1]/option[3]";
        public static string tarihbaslik="j_idt202:date2";
        public static string SecilecekGun = "//a[contains(text(),'30')]";
 


        ///Popup
        ///
        public static string popup= "//*[@id='DashboardForm:j_idt230'][1]";
        public static string popupkapat = "//*[@id='DashboardForm:j_idt230']/div[1]/a/span";
    }
}
