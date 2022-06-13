﻿using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace AdresYazici
{
    public partial class KargoOtomasyon : Form
    {
        public KargoOtomasyon()
        {
            InitializeComponent();
        }

        string[] ILLER = new string[81] {
            "ADANA","ADIYAMAN","AFYON","AĞRI","AMASYA","ANKARA","ANTALYA","ARTVİN","AYDIN","BALIKESİR","BİLECİK","BİNGÖL","BİTLİS","BOLU","BURDUR","BURSA",
            "ÇANAKKALE","ÇANKIRI","ÇORUM","DENİZLİ","DİYARBAKIR","EDİRNE","ELAZIĞ","ERZİNCAN","ERZURUM","ESKİŞEHİR","GAZİANTEP","GİRESUN","GÜMÜŞHANE",
            "HAKKARİ","HATAY","ISPARTA","İÇEL","İSTANBUL","İZMİR","KARS","KASTAMONU","KAYSERİ","KIRKLARELİ","KIRŞEHİR","KOCAELİ","KONYA","KÜTAHYA",
            "MALATYA","MANİSA","KAHRAMANMARAŞ","MARDİN","MUĞLA","MUŞ","NEVŞEHİR","NİĞDE","ORDU","RİZE","SAKARYA","SAMSUN","SİİRT","SİNOP","SİVAS",
            "TEKİRDAĞ","TOKAT","TRABZON","TUNCELİ","ŞANLIURFA","UŞAK","VAN","YOZGAT","ZONGULDAK","AKSARAY","BAYBURT","KARAMAN","KIRIKKALE","BATMAN",
            "ŞIRNAK","BARTIN","ARDAHAN","IĞDIR","YALOVA","KARABÜK","KİLİS","OSMANİYE","DÜZCE"
        };

        string[,] ILCELER = new string[,] {
            {"ALADAĞ", "1"},{"CEYHAN", "1"},{"ÇUKUROVA", "1"},{"FEKE", "1"},{"İMAMOĞLU", "1"},{"KARAİSALI", "1"},{"KARATAŞ", "1"},{"KOZAN", "1"},
            {"POZANTI", "1"},{"SAİMBEYLİ", "1"},{"SARIÇAM", "1"},{"SEYHAN", "1"},{"TUFANBEYLİ", "1"},{"YUMURTALIK", "1"},{"YÜREĞİR", "1"},
            {"BESNİ", "2"},{"ÇELİKHAN", "2"},{"GERGER", "2"},{"GÖLBAŞI", "2"},{"KAHTA", "2"},{"MERKEZ", "2"},{"SAMSAT", "2"},{"SİNCİK", "2"},
            {"TUT", "2"},{"BAŞMAKÇI", "3"},{"BAYAT", "3"},{"BOLVADİN", "3"},{"ÇAY", "3"},{"ÇOBANLAR", "3"},{"DAZKIRI", "3"},{"DİNAR", "3"},
            {"EMİRDAĞ", "3"},{"EVCİLER", "3"},{"HOCALAR", "3"},{"İHSANİYE", "3"},{"İSCEHİSAR", "3"},{"KIZILÖREN", "3"},{"MERKEZ", "3"},
            {"SANDIKLI", "3"},{"SİNANPAŞA", "3"},{"SULTANDAĞI", "3"},{"ŞUHUT", "3"},{"DİYADİN", "4"},{"DOĞUBAYAZIT", "4"},{"ELEŞKİRT", "4"},
            {"HAMUR", "4"},{"MERKEZ", "4"},{"PATNOS", "4"},{"TAŞLIÇAY", "4"},{"TUTAK", "4"},{"AĞAÇÖREN", "68"},{"ESKİL", "68"},{"GÜLAĞAÇ", "68"},
            {"GÜZELYURT", "68"},{"MERKEZ", "68"},{"ORTAKÖY", "68"},{"SARIYAHŞİ", "68"},{"SULTANHANI", "68"},{"GÖYNÜCEK", "5"},{"GÜMÜŞHACIKÖY", "5"},
            {"HAMAMÖZÜ", "5"},{"MERKEZ", "5"},{"MERZİFON", "5"},{"SULUOVA", "5"},{"TAŞOVA", "5"},{"AKYURT", "6"},{"ALTINDAĞ", "6"},{"AYAŞ", "6"},
            {"BALA", "6"},{"BEYPAZARI", "6"},{"ÇAMLIDERE", "6"},{"ÇANKAYA", "6"},{"ÇUBUK", "6"},{"ELMADAĞ", "6"},{"ETİMESGUT", "6"},{"EVREN", "6"},
            {"GÖLBAŞI", "6"},{"GÜDÜL", "6"},{"HAYMANA", "6"},{"KAHRAMANKAZAN", "6"},{"KALECİK", "6"},{"KEÇİÖREN", "6"},{"KIZILCAHAMAM", "6"},
            {"MAMAK", "6"},{"NALLIHAN", "6"},{"POLATLI", "6"},{"PURSAKLAR", "6"},{"SİNCAN", "6"},{"ŞEREFLİKOÇHİSAR", "6"},{"YENİMAHALLE", "6"},
            {"AKSEKİ", "7"},{"AKSU", "7"},{"ALANYA", "7"},{"DEMRE", "7"},{"DÖŞEMEALTI", "7"},{"ELMALI", "7"},{"FİNİKE", "7"},{"GAZİPAŞA", "7"},
            {"GÜNDOĞMUŞ", "7"},{"İBRADI", "7"},{"KAŞ", "7"},{"KEMER", "7"},{"KEPEZ", "7"},{"KONYAALTI", "7"},{"KORKUTELİ", "7"},{"KUMLUCA", "7"},
            {"MANAVGAT", "7"},{"MURATPAŞA", "7"},{"SERİK", "7"},{"ÇILDIR", "75"},{"DAMAL", "75"},{"GÖLE", "75"},{"HANAK", "75"},{"MERKEZ", "75"},
            {"POSOF", "75"},{"ARDANUÇ", "8"},{"ARHAVİ", "8"},{"BORÇKA", "8"},{"HOPA", "8"},{"KEMALPAŞA", "8"},{"MERKEZ", "8"},{"MURGUL", "8"},
            {"ŞAVŞAT", "8"},{"YUSUFELİ", "8"},{"BOZDOĞAN", "9"},{"BUHARKENT", "9"},{"ÇİNE", "9"},{"DİDİM", "9"},{"EFELER", "9"},{"GERMENCİK", "9"},
            {"İNCİRLİOVA", "9"},{"KARACASU", "9"},{"KARPUZLU", "9"},{"KOÇARLI", "9"},{"KÖŞK", "9"},{"KUŞADASI", "9"},{"KUYUCAK", "9"},
            {"NAZİLLİ", "9"},{"SÖKE", "9"},{"SULTANHİSAR", "9"},{"YENİPAZAR", "9"},{"ALTIEYLÜL", "10"},{"AYVALIK", "10"},{"BALYA", "10"},
            {"BANDIRMA", "10"},{"BİGADİÇ", "10"},{"BURHANİYE", "10"},{"DURSUNBEY", "10"},{"EDREMİT", "10"},{"ERDEK", "10"},{"GÖMEÇ", "10"},
            {"GÖNEN", "10"},{"HAVRAN", "10"},{"İVRİNDİ", "10"},{"KARESİ", "10"},{"KEPSUT", "10"},{"MANYAS", "10"},{"MARMARA", "10"},
            {"SAVAŞTEPE", "10"},{"SINDIRGI", "10"},{"SUSURLUK", "10"},{"AMASRA", "74"},{"KURUCAŞİLE", "74"},{"MERKEZ", "74"},{"ULUS", "74"},
            {"BEŞİRİ", "72"},{"GERCÜŞ", "72"},{"HASANKEYF", "72"},{"KOZLUK", "72"},{"MERKEZ", "72"},{"SASON", "72"},{"AYDINTEPE", "69"},
            {"DEMİRÖZÜ", "69"},{"MERKEZ", "69"},{"BOZÜYÜK", "11"},{"GÖLPAZARI", "11"},{"İNHİSAR", "11"},{"MERKEZ", "11"},{"OSMANELİ", "11"},
            {"PAZARYERİ", "11"},{"SÖĞÜT", "11"},{"YENİPAZAR", "11"},{"ADAKLI", "12"},{"GENÇ", "12"},{"KARLIOVA", "12"},{"KİĞI", "12"},
            {"MERKEZ", "12"},{"SOLHAN", "12"},{"YAYLADERE", "12"},{"YEDİSU", "12"},{"ADİLCEVAZ", "13"},{"AHLAT", "13"},{"GÜROYMAK", "13"},
            {"HİZAN", "13"},{"MERKEZ", "13"},{"MUTKİ", "13"},{"TATVAN", "13"},{"DÖRTDİVAN", "14"},{"GEREDE", "14"},{"GÖYNÜK", "14"},
            {"KIBRISCIK", "14"},{"MENGEN", "14"},{"MERKEZ", "14"},{"MUDURNU", "14"},{"SEBEN", "14"},{"YENİÇAĞA", "14"},{"AĞLASUN", "15"},
            {"ALTINYAYLA", "15"},{"BUCAK", "15"},{"ÇAVDIR", "15"},{"ÇELTİKÇİ", "15"},{"GÖLHİSAR", "15"},{"KARAMANLI", "15"},{"KEMER", "15"},
            {"MERKEZ", "15"},{"TEFENNİ", "15"},{"YEŞİLOVA", "15"},{"BÜYÜKORHAN", "16"},{"GEMLİK", "16"},{"GÜRSU", "16"},{"HARMANCIK", "16"},
            {"İNEGÖL", "16"},{"İZNİK", "16"},{"KARACABEY", "16"},{"KELES", "16"},{"KESTEL", "16"},{"MUDANYA", "16"},{"MUSTAFAKEMALPAŞA", "16"},
            {"NİLÜFER", "16"},{"ORHANELİ", "16"},{"ORHANGAZİ", "16"},{"OSMANGAZİ", "16"},{"YENİŞEHİR", "16"},{"YILDIRIM", "16"},{"AYVACIK", "17"},
            {"BAYRAMİÇ", "17"},{"BİGA", "17"},{"BOZCAADA", "17"},{"ÇAN", "17"},{"ECEABAT", "17"},{"EZİNE", "17"},{"GELİBOLU", "17"},
            {"GÖKÇEADA", "17"},{"LAPSEKİ", "17"},{"MERKEZ", "17"},{"YENİCE", "17"},{"ATKARACALAR", "18"},{"BAYRAMÖREN", "18"},{"ÇERKEŞ", "18"},
            {"ELDİVAN", "18"},{"ILGAZ", "18"},{"KIZILIRMAK", "18"},{"KORGUN", "18"},{"KURŞUNLU", "18"},{"MERKEZ", "18"},{"ORTA", "18"},
            {"ŞABANÖZÜ", "18"},{"YAPRAKLI", "18"},{"ALACA", "19"},{"BAYAT", "19"},{"BOĞAZKALE", "19"},{"DODURGA", "19"},{"İSKİLİP", "19"},
            {"KARGI", "19"},{"LAÇİN", "19"},{"MECİTÖZÜ", "19"},{"MERKEZ", "19"},{"OĞUZLAR", "19"},{"ORTAKÖY", "19"},{"OSMANCIK", "19"},
            {"SUNGURLU", "19"},{"UĞURLUDAĞ", "19"},{"ACIPAYAM", "20"},{"BABADAĞ", "20"},{"BAKLAN", "20"},{"BEKİLLİ", "20"},{"BEYAĞAÇ", "20"},
            {"BOZKURT", "20"},{"BULDAN", "20"},{"ÇAL", "20"},{"ÇAMELİ", "20"},{"ÇARDAK", "20"},{"ÇİVRİL", "20"},{"GÜNEY", "20"},{"HONAZ", "20"},
            {"KALE", "20"},{"MERKEZEFENDİ", "20"},{"PAMUKKALE", "20"},{"SARAYKÖY", "20"},{"SERİNHİSAR", "20"},{"TAVAS", "20"},{"BAĞLAR", "21"},
            {"BİSMİL", "21"},{"ÇERMİK", "21"},{"ÇINAR", "21"},{"ÇÜNGÜŞ", "21"},{"DİCLE", "21"},{"EĞİL", "21"},{"ERGANİ", "21"},{"HANİ", "21"},
            {"HAZRO", "21"},{"KAYAPINAR", "21"},{"KOCAKÖY", "21"},{"KULP", "21"},{"LİCE", "21"},{"SİLVAN", "21"},{"SUR", "21"},{"YENİŞEHİR", "21"},
            {"AKÇAKOCA", "81"},{"CUMAYERİ", "81"},{"ÇİLİMLİ", "81"},{"GÖLYAKA", "81"},{"GÜMÜŞOVA", "81"},{"KAYNAŞLI", "81"},{"MERKEZ", "81"},
            {"YIĞILCA", "81"},{"ENEZ", "22"},{"HAVSA", "22"},{"İPSALA", "22"},{"KEŞAN", "22"},{"LALAPAŞA", "22"},{"MERİÇ", "22"},{"MERKEZ", "22"},
            {"SÜLOĞLU", "22"},{"UZUNKÖPRÜ", "22"},{"AĞIN", "23"},{"ALACAKAYA", "23"},{"ARICAK", "23"},{"BASKİL", "23"},{"KARAKOÇAN", "23"},
            {"KEBAN", "23"},{"KOVANCILAR", "23"},{"MADEN", "23"},{"MERKEZ", "23"},{"PALU", "23"},{"SİVRİCE", "23"},{"ÇAYIRLI", "24"},
            {"İLİÇ", "24"},{"KEMAH", "24"},{"KEMALİYE", "24"},{"MERKEZ", "24"},{"OTLUKBELİ", "24"},{"REFAHİYE", "24"},{"TERCAN", "24"},
            {"ÜZÜMLÜ", "24"},{"AŞKALE", "25"},{"AZİZİYE", "25"},{"ÇAT", "25"},{"HINIS", "25"},{"HORASAN", "25"},{"İSPİR", "25"},
            {"KARAÇOBAN", "25"},{"KARAYAZI", "25"},{"KÖPRÜKÖY", "25"},{"NARMAN", "25"},{"OLTU", "25"},{"OLUR", "25"},{"PALANDÖKEN", "25"},
            {"PASİNLER", "25"},{"PAZARYOLU", "25"},{"ŞENKAYA", "25"},{"TEKMAN", "25"},{"TORTUM", "25"},{"UZUNDERE", "25"},{"YAKUTİYE", "25"},
            {"ALPU", "26"},{"BEYLİKOVA", "26"},{"ÇİFTELER", "26"},{"GÜNYÜZÜ", "26"},{"HAN", "26"},{"İNÖNÜ", "26"},{"MAHMUDİYE", "26"},
            {"MİHALGAZİ", "26"},{"MİHALIÇÇIK", "26"},{"ODUNPAZARI", "26"},{"SARICAKAYA", "26"},{"SEYİTGAZİ", "26"},{"SİVRİHİSAR", "26"},
            {"TEPEBAŞI", "26"},{"ARABAN", "27"},{"İSLAHİYE", "27"},{"KARKAMIŞ", "27"},{"NİZİP", "27"},{"NURDAĞI", "27"},{"OĞUZELİ", "27"},
            {"ŞAHİNBEY", "27"},{"ŞEHİTKAMİL", "27"},{"YAVUZELİ", "27"},{"ALUCRA", "28"},{"BULANCAK", "28"},{"ÇAMOLUK", "28"},{"ÇANAKÇI", "28"},
            {"DERELİ", "28"},{"DOĞANKENT", "28"},{"ESPİYE", "28"},{"EYNESİL", "28"},{"GÖRELE", "28"},{"GÜCE", "28"},{"KEŞAP", "28"},{"MERKEZ", "28"},
            {"PİRAZİZ", "28"},{"ŞEBİNKARAHİSAR", "28"},{"TİREBOLU", "28"},{"YAĞLIDERE", "28"},{"KELKİT", "29"},{"KÖSE", "29"},{"KÜRTÜN", "29"},
            {"MERKEZ", "29"},{"ŞİRAN", "29"},{"TORUL", "29"},{"ÇUKURCA", "30"},{"DERECİK", "30"},{"MERKEZ", "30"},{"ŞEMDİNLİ", "30"},{"YÜKSEKOVA", "30"},
            {"ALTINÖZÜ", "31"},{"ANTAKYA", "31"},{"ARSUZ", "31"},{"BELEN", "31"},{"DEFNE", "31"},{"DÖRTYOL", "31"},{"ERZİN", "31"},{"HASSA", "31"},
            {"İSKENDERUN", "31"},{"KIRIKHAN", "31"},{"KUMLU", "31"},{"PAYAS", "31"},{"REYHANLI", "31"},{"SAMANDAĞ", "31"},{"YAYLADAĞI", "31"},
            {"ARALIK", "76"},{"KARAKOYUNLU", "76"},{"MERKEZ", "76"},{"TUZLUCA", "76"},{"AKSU", "32"},{"ATABEY", "32"},{"EĞİRDİR", "32"},
            {"GELENDOST", "32"},{"GÖNEN", "32"},{"KEÇİBORLU", "32"},{"MERKEZ", "32"},{"SENİRKENT", "32"},{"SÜTÇÜLER", "32"},{"ŞARKİKARAAĞAÇ", "32"},
            {"ULUBORLU", "32"},{"YALVAÇ", "32"},{"YENİŞARBADEMLİ", "32"},{"ADALAR", "34"},{"ARNAVUTKÖY", "34"},{"ATAŞEHİR", "34"},{"AVCILAR", "34"},
            {"BAĞCILAR", "34"},{"BAHÇELİEVLER", "34"},{"BAKIRKÖY", "34"},{"BAŞAKŞEHİR", "34"},{"BAYRAMPAŞA", "34"},{"BEŞİKTAŞ", "34"},{"BEYKOZ", "34"},
            {"BEYLİKDÜZÜ", "34"},{"BEYOĞLU", "34"},{"BÜYÜKÇEKMECE", "34"},{"ÇATALCA", "34"},{"ÇEKMEKÖY", "34"},{"ESENLER", "34"},{"ESENYURT", "34"},
            {"EYÜPSULTAN", "34"},{"FATİH", "34"},{"GAZİOSMANPAŞA", "34"},{"GÜNGÖREN", "34"},{"KADIKÖY", "34"},{"KAĞITHANE", "34"},{"KARTAL", "34"},
            {"KÜÇÜKÇEKMECE", "34"},{"MALTEPE", "34"},{"PENDİK", "34"},{"SANCAKTEPE", "34"},{"SARIYER", "34"},{"SİLİVRİ", "34"},{"SULTANBEYLİ", "34"},
            {"SULTANGAZİ", "34"},{"ŞİLE", "34"},{"ŞİŞLİ", "34"},{"TUZLA", "34"},{"ÜMRANİYE", "34"},{"ÜSKÜDAR", "34"},{"ZEYTİNBURNU", "34"},
            {"ALİAĞA", "35"},{"BALÇOVA", "35"},{"BAYINDIR", "35"},{"BAYRAKLI", "35"},{"BERGAMA", "35"},{"BEYDAĞ", "35"},{"BORNOVA", "35"},
            {"BUCA", "35"},{"ÇEŞME", "35"},{"ÇİĞLİ", "35"},{"DİKİLİ", "35"},{"FOÇA", "35"},{"GAZİEMİR", "35"},{"GÜZELBAHÇE", "35"},{"KARABAĞLAR", "35"},
            {"KARABURUN", "35"},{"KARŞIYAKA", "35"},{"KEMALPAŞA", "35"},{"KINIK", "35"},{"KİRAZ", "35"},{"KONAK", "35"},{"MENDERES", "35"},
            {"MENEMEN", "35"},{"NARLIDERE", "35"},{"ÖDEMİŞ", "35"},{"SEFERİHİSAR", "35"},{"SELÇUK", "35"},{"TİRE", "35"},{"TORBALI", "35"},
            {"URLA", "35"},{"AFŞİN", "46"},{"ANDIRIN", "46"},{"ÇAĞLAYANCERİT", "46"},{"DULKADİROĞLU", "46"},{"EKİNÖZÜ", "46"},{"ELBİSTAN", "46"},
            {"GÖKSUN", "46"},{"NURHAK", "46"},{"ONİKİŞUBAT", "46"},{"PAZARCIK", "46"},{"TÜRKOĞLU", "46"},{"EFLANİ", "78"},{"ESKİPAZAR", "78"},
            {"MERKEZ", "78"},{"OVACIK", "78"},{"SAFRANBOLU", "78"},{"YENİCE", "78"},{"AYRANCI", "70"},{"BAŞYAYLA", "70"},{"ERMENEK", "70"},
            {"KAZIMKARABEKİR", "70"},{"MERKEZ", "70"},{"SARIVELİLER", "70"},{"AKYAKA", "36"},{"ARPAÇAY", "36"},{"DİGOR", "36"},{"KAĞIZMAN", "36"},
            {"MERKEZ", "36"},{"SARIKAMIŞ", "36"},{"SELİM", "36"},{"SUSUZ", "36"},{"ABANA", "37"},{"AĞLI", "37"},{"ARAÇ", "37"},{"AZDAVAY", "37"},
            {"BOZKURT", "37"},{"CİDE", "37"},{"ÇATALZEYTİN", "37"},{"DADAY", "37"},{"DEVREKANİ", "37"},{"DOĞANYURT", "37"},{"HANÖNÜ", "37"},
            {"İHSANGAZİ", "37"},{"İNEBOLU", "37"},{"KÜRE", "37"},{"MERKEZ", "37"},{"PINARBAŞI", "37"},{"SEYDİLER", "37"},{"ŞENPAZAR", "37"},
            {"TAŞKÖPRÜ", "37"},{"TOSYA", "37"},{"AKKIŞLA", "38"},{"BÜNYAN", "38"},{"DEVELİ", "38"},{"FELAHİYE", "38"},{"HACILAR", "38"},{"İNCESU", "38"},
            {"KOCASİNAN", "38"},{"MELİKGAZİ", "38"},{"ÖZVATAN", "38"},{"PINARBAŞI", "38"},{"SARIOĞLAN", "38"},{"SARIZ", "38"},{"TALAS", "38"},
            {"TOMARZA", "38"},{"YAHYALI", "38"},{"YEŞİLHİSAR", "38"},{"BAHŞILI", "71"},{"BALIŞEYH", "71"},{"ÇELEBİ", "71"},{"DELİCE", "71"},
            {"KARAKEÇİLİ", "71"},{"KESKİN", "71"},{"MERKEZ", "71"},{"SULAKYURT", "71"},{"YAHŞİHAN", "71"},{"BABAESKİ", "39"},{"DEMİRKÖY", "39"},
            {"KOFÇAZ", "39"},{"LÜLEBURGAZ", "39"},{"MERKEZ", "39"},{"PEHLİVANKÖY", "39"},{"PINARHİSAR", "39"},{"VİZE", "39"},{"AKÇAKENT", "40"},
            {"AKPINAR", "40"},{"BOZTEPE", "40"},{"ÇİÇEKDAĞI", "40"},{"KAMAN", "40"},{"MERKEZ", "40"},{"MUCUR", "40"},{"ELBEYLİ", "79"},{"MERKEZ", "79"},
            {"MUSABEYLİ", "79"},{"POLATELİ", "79"},{"BAŞİSKELE", "41"},{"ÇAYIROVA", "41"},{"DARICA", "41"},{"DERİNCE", "41"},{"DİLOVASI", "41"},
            {"GEBZE", "41"},{"GÖLCÜK", "41"},{"İZMİT", "41"},{"KANDIRA", "41"},{"KARAMÜRSEL", "41"},{"KARTEPE", "41"},{"KÖRFEZ", "41"},{"AHIRLI", "42"},
            {"AKÖREN", "42"},{"AKŞEHİR", "42"},{"ALTINEKİN", "42"},{"BEYŞEHİR", "42"},{"BOZKIR", "42"},{"CİHANBEYLİ", "42"},{"ÇELTİK", "42"},
            {"ÇUMRA", "42"},{"DERBENT", "42"},{"DEREBUCAK", "42"},{"DOĞANHİSAR", "42"},{"EMİRGAZİ", "42"},{"EREĞLİ", "42"},{"GÜNEYSINIR", "42"},
            {"HADİM", "42"},{"HALKAPINAR", "42"},{"HÜYÜK", "42"},{"ILGIN", "42"},{"KADINHANI", "42"},{"KARAPINAR", "42"},{"KARATAY", "42"},
            {"KULU", "42"},{"MERAM", "42"},{"SARAYÖNÜ", "42"},{"SELÇUKLU", "42"},{"SEYDİŞEHİR", "42"},{"TAŞKENT", "42"},{"TUZLUKÇU", "42"},
            {"YALIHÜYÜK", "42"},{"YUNAK", "42"},{"ALTINTAŞ", "43"},{"ASLANAPA", "43"},{"ÇAVDARHİSAR", "43"},{"DOMANİÇ", "43"},{"DUMLUPINAR", "43"},
            {"EMET", "43"},{"GEDİZ", "43"},{"HİSARCIK", "43"},{"MERKEZ", "43"},{"PAZARLAR", "43"},{"SİMAV", "43"},{"ŞAPHANE", "43"},{"TAVŞANLI", "43"},
            {"AKÇADAĞ", "44"},{"ARAPGİR", "44"},{"ARGUVAN", "44"},{"BATTALGAZİ", "44"},{"DARENDE", "44"},{"DOĞANŞEHİR", "44"},{"DOĞANYOL", "44"},
            {"HEKİMHAN", "44"},{"KALE", "44"},{"KULUNCAK", "44"},{"PÜTÜRGE", "44"},{"YAZIHAN", "44"},{"YEŞİLYURT", "44"},{"AHMETLİ", "45"},
            {"AKHİSAR", "45"},{"ALAŞEHİR", "45"},{"DEMİRCİ", "45"},{"GÖLMARMARA", "45"},{"GÖRDES", "45"},{"KIRKAĞAÇ", "45"},{"KÖPRÜBAŞI", "45"},
            {"KULA", "45"},{"SALİHLİ", "45"},{"SARIGÖL", "45"},{"SARUHANLI", "45"},{"SELENDİ", "45"},{"SOMA", "45"},{"ŞEHZADELER", "45"},
            {"TURGUTLU", "45"},{"YUNUSEMRE", "45"},{"ARTUKLU", "47"},{"DARGEÇİT", "47"},{"DERİK", "47"},{"KIZILTEPE", "47"},{"MAZIDAĞI", "47"},
            {"MİDYAT", "47"},{"NUSAYBİN", "47"},{"ÖMERLİ", "47"},{"SAVUR", "47"},{"YEŞİLLİ", "47"},{"AKDENİZ", "33"},{"ANAMUR", "33"},{"AYDINCIK", "33"},
            {"BOZYAZI", "33"},{"ÇAMLIYAYLA", "33"},{"ERDEMLİ", "33"},{"GÜLNAR", "33"},{"MEZİTLİ", "33"},{"MUT", "33"},{"SİLİFKE", "33"},{"TARSUS", "33"},
            {"TOROSLAR", "33"},{"YENİŞEHİR", "33"},{"BODRUM", "48"},{"DALAMAN", "48"},{"DATÇA", "48"},{"FETHİYE", "48"},{"KAVAKLIDERE", "48"},
            {"KÖYCEĞİZ", "48"},{"MARMARİS", "48"},{"MENTEŞE", "48"},{"MİLAS", "48"},{"ORTACA", "48"},{"SEYDİKEMER", "48"},{"ULA", "48"},{"YATAĞAN", "48"},
            {"BULANIK", "49"},{"HASKÖY", "49"},{"KORKUT", "49"},{"MALAZGİRT", "49"},{"MERKEZ", "49"},{"VARTO", "49"},{"ACIGÖL", "50"},{"AVANOS", "50"},
            {"DERİNKUYU", "50"},{"GÜLŞEHİR", "50"},{"HACIBEKTAŞ", "50"},{"KOZAKLI", "50"},{"MERKEZ", "50"},{"ÜRGÜP", "50"},{"ALTUNHİSAR", "51"},
            {"BOR", "51"},{"ÇAMARDI", "51"},{"ÇİFTLİK", "51"},{"MERKEZ", "51"},{"ULUKIŞLA", "51"},{"AKKUŞ", "52"},{"ALTINORDU", "52"},{"AYBASTI", "52"},
            {"ÇAMAŞ", "52"},{"ÇATALPINAR", "52"},{"ÇAYBAŞI", "52"},{"FATSA", "52"},{"GÖLKÖY", "52"},{"GÜLYALI", "52"},{"GÜRGENTEPE", "52"},
            {"İKİZCE", "52"},{"KABADÜZ", "52"},{"KABATAŞ", "52"},{"KORGAN", "52"},{"KUMRU", "52"},{"MESUDİYE", "52"},{"PERŞEMBE", "52"},{"ULUBEY", "52"},
            {"ÜNYE", "52"},{"BAHÇE", "80"},{"DÜZİÇİ", "80"},{"HASANBEYLİ", "80"},{"KADİRLİ", "80"},{"MERKEZ", "80"},{"SUMBAS", "80"},{"TOPRAKKALE", "80"},
            {"ARDEŞEN", "53"},{"ÇAMLIHEMŞİN", "53"},{"ÇAYELİ", "53"},{"DEREPAZARI", "53"},{"FINDIKLI", "53"},{"GÜNEYSU", "53"},{"HEMŞİN", "53"},
            {"İKİZDERE", "53"},{"İYİDERE", "53"},{"KALKANDERE", "53"},{"MERKEZ", "53"},{"PAZAR", "53"},{"ADAPAZARI", "54"},{"AKYAZI", "54"},
            {"ARİFİYE", "54"},{"ERENLER", "54"},{"FERİZLİ", "54"},{"GEYVE", "54"},{"HENDEK", "54"},{"KARAPÜRÇEK", "54"},{"KARASU", "54"},
            {"KAYNARCA", "54"},{"KOCAALİ", "54"},{"PAMUKOVA", "54"},{"SAPANCA", "54"},{"SERDİVAN", "54"},{"SÖĞÜTLÜ", "54"},{"TARAKLI", "54"},
            {"19 MAYIS", "55"},{"ALAÇAM", "55"},{"ASARCIK", "55"},{"ATAKUM", "55"},{"AYVACIK", "55"},{"BAFRA", "55"},{"CANİK", "55"},{"ÇARŞAMBA", "55"},
            {"HAVZA", "55"},{"İLKADIM", "55"},{"KAVAK", "55"},{"LADİK", "55"},{"SALIPAZARI", "55"},{"TEKKEKÖY", "55"},{"TERME", "55"},{"VEZİRKÖPRÜ", "55"},
            {"YAKAKENT", "55"},{"BAYKAN", "56"},{"ERUH", "56"},{"KURTALAN", "56"},{"MERKEZ", "56"},{"PERVARİ", "56"},{"ŞİRVAN", "56"},{"TİLLO", "56"},
            {"AYANCIK", "57"},{"BOYABAT", "57"},{"DİKMEN", "57"},{"DURAĞAN", "57"},{"ERFELEK", "57"},{"GERZE", "57"},{"MERKEZ", "57"},{"SARAYDÜZÜ", "57"},
            {"TÜRKELİ", "57"},{"AKINCILAR", "58"},{"ALTINYAYLA", "58"},{"DİVRİĞİ", "58"},{"DOĞANŞAR", "58"},{"GEMEREK", "58"},{"GÖLOVA", "58"},
            {"GÜRÜN", "58"},{"HAFİK", "58"},{"İMRANLI", "58"},{"KANGAL", "58"},{"KOYULHİSAR", "58"},{"MERKEZ", "58"},{"SUŞEHRİ", "58"},
            {"ŞARKIŞLA", "58"},{"ULAŞ", "58"},{"YILDIZELİ", "58"},{"ZARA", "58"},{"AKÇAKALE", "63"},{"BİRECİK", "63"},{"BOZOVA", "63"},
            {"CEYLANPINAR", "63"},{"EYYÜBİYE", "63"},{"HALFETİ", "63"},{"HALİLİYE", "63"},{"HARRAN", "63"},{"HİLVAN", "63"},{"KARAKÖPRÜ", "63"},
            {"SİVEREK", "63"},{"SURUÇ", "63"},{"VİRANŞEHİR", "63"},{"BEYTÜŞŞEBAP", "73"},{"CİZRE", "73"},{"GÜÇLÜKONAK", "73"},{"İDİL", "73"},
            {"MERKEZ", "73"},{"SİLOPİ", "73"},{"ULUDERE", "73"},{"ÇERKEZKÖY", "59"},{"ÇORLU", "59"},{"ERGENE", "59"},{"HAYRABOLU", "59"},{"KAPAKLI", "59"},
            {"MALKARA", "59"},{"MARMARAEREĞLİSİ", "59"},{"MURATLI", "59"},{"SARAY", "59"},{"SÜLEYMANPAŞA", "59"},{"ŞARKÖY", "59"},{"ALMUS", "60"},
            {"ARTOVA", "60"},{"BAŞÇİFTLİK", "60"},{"ERBAA", "60"},{"MERKEZ", "60"},{"NİKSAR", "60"},{"PAZAR", "60"},{"REŞADİYE", "60"},
            {"SULUSARAY", "60"},{"TURHAL", "60"},{"YEŞİLYURT", "60"},{"ZİLE", "60"},{"AKÇAABAT", "61"},{"ARAKLI", "61"},{"ARSİN", "61"},
            {"BEŞİKDÜZÜ", "61"},{"ÇARŞIBAŞI", "61"},{"ÇAYKARA", "61"},{"DERNEKPAZARI", "61"},{"DÜZKÖY", "61"},{"HAYRAT", "61"},{"KÖPRÜBAŞI", "61"},
            {"MAÇKA", "61"},{"OF", "61"},{"ORTAHİSAR", "61"},{"SÜRMENE", "61"},{"ŞALPAZARI", "61"},{"TONYA", "61"},{"VAKFIKEBİR", "61"},{"YOMRA", "61"},
            {"ÇEMİŞGEZEK", "62"},{"HOZAT", "62"},{"MAZGİRT", "62"},{"MERKEZ", "62"},{"NAZIMİYE", "62"},{"OVACIK", "62"},{"PERTEK", "62"},
            {"PÜLÜMÜR", "62"},{"BANAZ", "64"},{"EŞME", "64"},{"KARAHALLI", "64"},{"MERKEZ", "64"},{"SİVASLI", "64"},{"ULUBEY", "64"},{"BAHÇESARAY", "65"},
            {"BAŞKALE", "65"},{"ÇALDIRAN", "65"},{"ÇATAK", "65"},{"EDREMİT", "65"},{"ERCİŞ", "65"},{"GEVAŞ", "65"},{"GÜRPINAR", "65"},{"İPEKYOLU", "65"},
            {"MURADİYE", "65"},{"ÖZALP", "65"},{"SARAY", "65"},{"TUŞBA", "65"},{"ALTINOVA", "77"},{"ARMUTLU", "77"},{"ÇINARCIK", "77"},
            {"ÇİFTLİKKÖY", "77"},{"MERKEZ", "77"},{"TERMAL", "77"},{"AKDAĞMADENİ", "66"},{"AYDINCIK", "66"},{"BOĞAZLIYAN", "66"},{"ÇANDIR", "66"},
            {"ÇAYIRALAN", "66"},{"ÇEKEREK", "66"},{"KADIŞEHRİ", "66"},{"MERKEZ", "66"},{"SARAYKENT", "66"},{"SARIKAYA", "66"},{"SORGUN", "66"},
            {"ŞEFAATLİ", "66"},{"YENİFAKILI", "66"},{"YERKÖY", "66"},{"ALAPLI", "67"},{"ÇAYCUMA", "67"},{"DEVREK", "67"},{"EREĞLİ", "67"},
            {"GÖKÇEBEY", "67"},{"KİLİMLİ", "67"},{"KOZLU", "67"},{"MERKEZ", "67"}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ILLER.Length; i++)
            { txtIl.Items.Add(ILLER[i]); }
            txtIl.SelectedIndex = 6;
            txtIlce.SelectedIndex = 17;
            txtAd.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIlce.Items.Clear();
            string seciliIl = (txtIl.SelectedIndex + 1).ToString();
            for (int i = 0; i < 973; i++)
            { if (ILCELER[i, 1] == seciliIl) txtIlce.Items.Add(ILCELER[i, 0]); }
            txtIlce.SelectedIndex = 0;
            lblIl2.Text = "İl:  " + txtIl.Text;
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            lblAliciAdi.Text = "Alıcı Adı:  " + txtAd.Text + " " + txtSoyad.Text;
            txtAd.CharacterCasing = CharacterCasing.Upper;
            if (txtAd.Text.Length<1) txtAd.BackColor = Color.White;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            lblAliciAdi.Text = "Alıcı Adı:  " + txtAd.Text + " " + txtSoyad.Text;
            txtSoyad.CharacterCasing = CharacterCasing.Upper;
            if (txtSoyad.Text.Length < 1) txtSoyad.BackColor = Color.White;
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            lblAliciTelefon.Text = "Alıcı Telefon:  0 " + txtTelefon.Text;
            if (txtTelefon.Text.Length < 1) txtTelefon.BackColor = Color.White;
        }

        private void txtMahalle_TextChanged(object sender, EventArgs e)
        {
            lblMahalle2.Text = "Mahalle:  " + txtMahalle.Text;
            txtMahalle.CharacterCasing = CharacterCasing.Upper;
            if (txtMahalle.Text.Length < 1) txtMahalle.BackColor = Color.White;
        }

        private void txtCaddeSokak_TextChanged(object sender, EventArgs e)
        {
            lblCaddeSokak2.Text = "Cadde/Sokak:  " + txtCaddeSokak.Text;
            txtCaddeSokak.CharacterCasing = CharacterCasing.Upper;
            if (txtCaddeSokak.Text.Length < 1) txtCaddeSokak.BackColor = Color.White;
        }

        private void txtBinaNo_TextChanged(object sender, EventArgs e)
        {
            lblBinaNo2.Text = "Bina No:  " + txtBinaNo.Text;
            txtBinaNo.CharacterCasing = CharacterCasing.Upper;
        }

        private void numKat_ValueChanged(object sender, EventArgs e)
        {
            lblKat2.Text = "Kat:  " + numKat.Value.ToString();
        }

        private void numDaire_ValueChanged(object sender, EventArgs e)
        {
            lblDaireNo.Text = "Daire No:  " + numDaire.Value.ToString();
        }

        private void HarfDenetimiAd(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
            if ((int)e.KeyChar == 32) e.Handled = false;
        }

        private void HarfDenetimiSoyad(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar)) e.Handled = true;
            if ((int)e.KeyChar == 32) e.Handled = true;
        }

        private void HarfDenetimiAdres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) e.Handled = true;
            if ((int)e.KeyChar == 32) e.Handled = false;
        }

        private void HarfDenetimiBinaNo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)) e.Handled = true;
            if ((int)e.KeyChar == 32) e.Handled = false;
            //if (!char.IsNumber(e.KeyChar)) e.Handled = true;
        }

        private void txtIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIlce2.Text = "İlçe:  " + txtIlce.Text;
        }

        private void txtTelefon_Click(object sender, EventArgs e)
        {
            if (txtTelefon.Text[1].ToString() == " ")
            {
                txtTelefon.Select(0, 0);
            }
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            KontrolEt();
            if (hata == false)
            {
                dokumaniYazdir.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 840, 300);
                dokumaniOnizle.ShowDialog();
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            KontrolEt();
            if (hata == false)
            {
                dokumaniYazdir.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 840, 300);
                DialogResult yazdir = yazdirmaSecenekleri.ShowDialog();
                if (yazdir == DialogResult.OK) dokumaniYazdir.Print();
            }
        }

        Font YaziTipi(bool kalinlik = false, byte boyut = 15)
        {
            Font font; 
            if (kalinlik == true) font = new Font("Bahnschrift", boyut, FontStyle.Bold);
            else font = new Font("Bahnschrift", boyut, FontStyle.Regular);
            return font;
        }

        private void dokumaniYazdir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SolidBrush yazi = new SolidBrush(Color.Black);
            Pen cizgi = new Pen(Color.Black);

            // X: 840 | Y: 380

            e.Graphics.DrawLine(cizgi, new Point(10, 10), new Point(780, 10));
            e.Graphics.DrawLine(cizgi, new Point(10, 290), new Point(780, 290));

            e.Graphics.DrawLine(cizgi, new Point(222, 70), new Point(222, 230));
            e.Graphics.DrawLine(cizgi, new Point(10, 230), new Point(222, 230));

            e.Graphics.DrawLine(cizgi, new Point(10, 10), new Point(10, 290));
            e.Graphics.DrawString("GÖNDERİCİ: " + txtGonderici.Text, YaziTipi(true, 26), yazi, 30, 28);
            e.Graphics.DrawLine(cizgi, new Point(10, 70), new Point(780, 70));
            e.Graphics.DrawString("ALICI AD SOYAD:", YaziTipi(true, 15), yazi, 30, 87); e.Graphics.DrawString(txtAd.Text + " " + txtSoyad.Text, YaziTipi(true, 15), yazi, 234, 87);
            e.Graphics.DrawLine(cizgi, new Point(10, 120), new Point(780, 120));
            e.Graphics.DrawString("TELEFON:", YaziTipi(true, 15), yazi, 60, 137); e.Graphics.DrawString("0 " + txtTelefon.Text, YaziTipi(true, 15), yazi, 234, 137);
            e.Graphics.DrawLine(cizgi, new Point(10, 170), new Point(780, 170));
            e.Graphics.DrawString("ADRES:", YaziTipi(true, 15), yazi, 70, 192); 
            e.Graphics.DrawString(txtMahalle.Text, YaziTipi(true, 15), yazi, 234, 175);
            e.Graphics.DrawString(txtCaddeSokak.Text, YaziTipi(true, 15), yazi, 234, 210);
            e.Graphics.DrawString(String.Format($"Bina No: {txtBinaNo.Text} / Kat: {numKat.Text} / Daire: {numDaire.Text}     {txtIlce.Text} / {txtIl.Text}"), YaziTipi(true, 15), yazi, 30, 250);

            e.Graphics.DrawLine(cizgi, new Point(780, 10), new Point(780, 290));
        }

        bool hata = false;
        private void KontrolEt()
        {
            byte hataSayisi = 0;
            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            txtMahalle.BackColor = Color.White;
            txtCaddeSokak.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                txtAd.Clear();
                txtAd.BackColor = Color.FromArgb(255, 180, 180);
                hataSayisi++;
            }
            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                txtSoyad.BackColor = Color.FromArgb(255, 180, 180);
                hataSayisi++;
            }
            if (txtTelefon.Text[1].ToString() == " " || lblAliciTelefon.Text.Length != 33)
            {
                txtTelefon.BackColor = Color.FromArgb(255, 180, 180);
                hataSayisi++;
            }
            if (string.IsNullOrWhiteSpace(txtMahalle.Text))
            {
                txtMahalle.Clear();
                txtMahalle.BackColor = Color.FromArgb(255, 180, 180);
                hataSayisi++;
            }
            if (string.IsNullOrWhiteSpace(txtCaddeSokak.Text))
            {
                txtCaddeSokak.Clear();
                txtCaddeSokak.BackColor = Color.FromArgb(255, 180, 180);
                hataSayisi++;
            }
            if (hataSayisi == 0) hata = false; else hata = true;
        }
    }
}