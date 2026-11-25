using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberDump2026
{
    internal class Program
    {
        static void Ir(string szoveg)
        {
            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.Write(szoveg[i]);
                Thread.Sleep(15);
            }

            Console.WriteLine();
            Thread.Sleep(350);
        }
        static void Beszel(string nev, string szoveg)
        {
            if (nev == "Flashback")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (nev == "Csonka")
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (nev == "Miquel")
                Console.ForegroundColor = ConsoleColor.Green;
            else if (nev == "Flashback [narráció]")
                Console.ForegroundColor = ConsoleColor.DarkRed;
            else if (nev == "Robot")
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (nev == "Büfés")
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (nev == "Király")
                Console.ForegroundColor = ConsoleColor.Magenta;
            else if (nev == "Tömeg")
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            else
                Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write(nev + ": ");

            if (nev != "Flashback [narráció]")
                Console.ResetColor();

            Ir(szoveg);
            Console.ResetColor();
        }
        static void Tovabb()
        {
            Console.WriteLine("\nENTER a folytatáshoz...");
            Console.ReadLine();
            Console.Clear();
        }

        static void Main()
        {
            int penz = 2000;
            int alkatresz = 0;
            string valasz = "";
            Random rnd = new Random();

            bool munka1 = false;
            bool munka2 = false;
            bool munka3 = false;
            bool munka4 = false;
            bool munka5 = false;
            bool munka6 = false;

            Console.Title = "A mocskos Debrecen 2077";

            Console.ForegroundColor = ConsoleColor.Red;

            Ir("========================================");
            Ir("         A MOCSKOS DEBRECEN 2077");
            Ir("        FLASHBACK TRAGIKOMÉDIÁJA");
            Ir("========================================");

            Console.ResetColor();

            Ir("\nRendezte: Flashback");
            Ir("Forgatókönyv: Flashback");
            Ir("Műfaj: Katasztrofális komédia");

            Tovabb();

            Ir("========== GYORSTALPALÓ ==========\n");

            Ir("A játék három főszereplő kalandját követi.");
            Ir("A párbeszédek színei segítenek megkülönböztetni őket.\n");

            Beszel("Flashback", "Zseni, manipulátor és főszereplő.");
            Beszel("Flashback [narráció]",
                "A sötétpiros szöveget csak te, a játékos hallod.");

            Beszel("Miquel",
                "Szemüveges, magkedvelő Csocsaki Isten.");

            Beszel("Csonka",
                "Én lenni Gyuri. Én beszélni magyar.");

            Ir("\nA döntéseknél írj be egy számot!");
            Ir("A történet az ENTER megnyomásával folytatódik.");

            Tovabb();

            Ir("===== PROLÓGUS: AZ UTOLSÓ INFÓÓRA =====\n");

            Ir("2026. Egy teljesen átlagos informatikaóra.");
            Ir("Miquel asztalán három zacskó napraforgómag hever.");

            Beszel("Miquel", "Én vagyok a Csocsaki Isten!");

            Beszel("Tömeg", "FÚÚÚÚJ!");

            Beszel("Flashback [narráció]",
                "A komédiám szereplőválogatása sajnos elég szegényes volt.");

            Beszel("Csonka", "Én elmenni hugyni.");

            Ir("\nCsonka öt perccel később visszatér.");
            Ir("Egy furcsa, mikrohullámú sütőre hasonlító gépet hoz.");

            Beszel("Csonka", "Én találni gép folyosó.");

            Beszel("Miquel", "Engem nem érdekel, megyek Tarkovozni.");

            Beszel("Flashback", "Csonka, nyomd meg a piros gombot.");

            Beszel("Csonka", "Miért én?");

            Beszel("Flashback", "Mert te vagy a legalkalmasabb.");

            Beszel("Flashback [narráció]",
                "Valójában fogalmam sem volt, mire való a gomb.");

            Ir("\nCsonka megnyomja a gombot.");

            for (int i = 3; i > 0; i--)
            {
                Ir(i + "...");
            }

            Ir("IDŐUTAZÁS ELINDÍTVA!");
            Ir("CÉLÁLLOMÁS: DEBRECEN, 2077");

            Beszel("Flashback", "Na, ez mondjuk váratlan.");

            Tovabb();

            Ir("===== I. FELVONÁS: A MOCSKOS DEBRECEN =====\n");

            Ir("A három barát egy koszos utcán tér magához.");
            Ir("Repülő villamosok, robotgalambok és brit zászlók mindenhol.");

            Ir("\nEgy hatalmas kijelző villog:\n");
            Ir("BRITANNIAI VILÁGBIRODALOM");
            Ir("47. KÖRZET - DEBRECEN");
            Ir("2077");

            Beszel("Csonka", "Hol lenni Magyarország?");

            Beszel("Flashback",
                "Úgy tűnik, Britannia elfoglalta az egész világot.");

            Beszel("Csonka", "Ukrajna is?");

            Beszel("Flashback", "Minden országot.");

            Beszel("Csonka", "Akkor én most brit Gyuri?");

            Beszel("Flashback [narráció]",
                "Gyuri öt másodperc alatt megoldotta az identitásválságát.");

            Beszel("Miquel", "Engem nem érdekel, megyek Tarkovozni.");

            Ir("Miquel előveszi a telefonját.");

            Ir("HIBA: AZ ESCAPE FROM TARKOV NEM ELÉRHETŐ.");

            Beszel("Robot", "A szervereket 2051-ben leállították.");

            Beszel("Miquel", "Vigyünk vissza. MOST.");

            Ir("\nA robot megvizsgálja az időgépet.");

            Beszel("Robot", "Három alkatrész hiányzik.");

            Ir("1. Tápegység");
            Ir("2. Vezérlőchip");
            Ir("3. Időkristály");

            Beszel("Robot", "A tápegységet a Gyros 3000-ben árulják.");

            Beszel("Flashback", "Remek. Indulunk.");

            Beszel("Flashback [narráció]",
                "A hazajutásunk egy debreceni gyrososon múlt. Csodálatos.");

            Tovabb();

            Ir("===== II. FELVONÁS: A GYROSINFLÁCIÓ =====\n");

            Ir("A csapat megérkezik a Gyros 3000 étterembe.");

            Beszel("Büfés", "A tápegység ötezer forint.");

            Beszel("Flashback", "Van kétezer.");

            Beszel("Büfés", "Akkor nézegetni lehet.");

            Beszel("Miquel", "Isteni kedvezmény?");

            Beszel("Büfés", "Nincs ilyen kuponunk.");

            Beszel("Csonka", "Én éhes lenni.");

            Beszel("Flashback", "Először pénzt szerzünk.");

            Beszel("Flashback [narráció]",
                "Kezdetét vette a produkció finanszírozása.");

            while (penz < 5000)
            {
                Ir("\n--------------------------------");
                Ir("Költségvetés: " + penz + "/5000 Ft");
                Ir("--------------------------------");

                if (munka1 == false)
                    Ir("1 - Csonka utcazenélése (+800 Ft)");

                if (munka2 == false)
                    Ir("2 - Miquel isteni fellépése (+1000 Ft)");

                if (munka3 == false)
                    Ir("3 - Flashback üzleti tárgyalása (+1200 Ft)");

                if (munka4 == false)
                    Ir("4 - Robotgalambok etetése (+700 Ft)");

                if (munka5 == false)
                    Ir("5 - Csocsaki Magbolt (+1300 Ft)");

                if (munka6 == false)
                    Ir("6 - Stand-up fellépés (+1100 Ft)");

                Console.Write("\nVálassz: ");
                valasz = Console.ReadLine();

                if (valasz == "1" && munka1 == false)
                {
                    munka1 = true;

                    Ir("\nCsonka szerez egy mikrofont.");

                    Beszel("Csonka", "Én most énekelni!");

                    Beszel("Tömeg", "NEEEEE!");

                    Beszel("Járókelő", "Nyolcszáz forint, ha abbahagyod.");

                    Beszel("Csonka", "Én sikeres zenész.");

                    Beszel("Flashback [narráció]",
                        "Egyetlen koncert. Egyetlen panaszmentes másodperc sem.");

                    penz += 800;
                }
                else if (valasz == "2" && munka2 == false)
                {
                    munka2 = true;

                    Ir("\nMiquel feláll egy kukára.");
                    Ir("Megigazítja a szemüvegét.");

                    Beszel("Miquel", "ÍME A CSOCSAKI ISTEN!");

                    Beszel("Tömeg", "FÚÚÚÚJ!");

                    Beszel("Járókelő", "Mi a gyász ez?");

                    Beszel("Másik járókelő", "Mi ez, David Martinez?");

                    Ir("Miquel Tony Montanát emlegetve énekelni kezd.");

                    Beszel("Csonka", "Miquel, te leszállni kuka.");

                    Beszel("Járókelő", "Egy ezres, ha elviszitek.");

                    Beszel("Flashback", "Megállapodtunk.");

                    Beszel("Miquel", "Újabb hívő!");

                    Beszel("Flashback [narráció]",
                        "A közönség fizetett, hogy véget érjen az előadás.");

                    penz += 1000;
                }
                else if (valasz == "3" && munka3 == false)
                {
                    munka3 = true;

                    Beszel("Üzletember", "Munkát keres?");

                    Beszel("Flashback", "Én munkát teremtek.");

                    Beszel("Üzletember", "Mihez ért?");

                    Beszel("Flashback", "Mindenhez.");

                    Ir("Flashback megoldja az üzletember logikai rejtvényét.");

                    Beszel("Üzletember", "Ez tényleg lenyűgöző.");

                    Beszel("Flashback", "Igen, ezt gyakran hallom.");

                    Beszel("Csonka", "Te most először hallani.");

                    Beszel("Flashback [narráció]",
                        "Ezt a mellékszereplőt később ki kell írnom.");

                    penz += 1200;
                }
                else if (valasz == "4" && munka4 == false)
                {
                    munka4 = true;

                    Ir("\nA csapat robotgalambokat etet.");

                    Beszel("Csonka", "Gyere ide repülő kenyérpirító!");

                    Beszel("Galamb", "Kérem az adatkezelési hozzájárulást.");

                    Beszel("Csonka", "Madárnak lenni GDPR?");

                    Beszel("Galamb", "Természetesen.");

                    Beszel("Flashback [narráció]",
                        "2077-ben már a galamboknak is jobb a jogi képviseletük.");

                    penz += 700;
                }
                else if (valasz == "5" && munka5 == false)
                {
                    munka5 = true;

                    Ir("\nMiquel kipakolja a magjait az asztalra.");

                    Beszel("Miquel", "Isteni napraforgómag eladó!");

                    Beszel("Vásárló", "Ez sima szotyola.");

                    Beszel("Miquel", "Megáldott szotyola.");

                    Beszel("Vásárló", "Akkor kérek egy zacskóval.");

                    Beszel("Flashback", "Én kérem a bevétel kilencven százalékát.");

                    Beszel("Miquel", "Te miért?");

                    Beszel("Flashback", "Szellemi tulajdon.");

                    penz += 1300;
                }
                else if (valasz == "6" && munka6 == false)
                {
                    munka6 = true;

                    Ir("\nFlashback jelentkezik egy robotoknak szóló stand-upra.");

                    Beszel("Flashback", "Van két tökéletes poénom.");

                    Beszel("Miquel", "Mik azok?");

                    Beszel("Flashback", "Ti.");

                    Beszel("Robot", "HA. HA. HA.");

                    Beszel("Csonka", "Én kérni szerzői jog!");

                    Beszel("Flashback [narráció]",
                        "Végre egy közönség, amely értékeli a humoromat.");

                    penz += 1100;
                }
                else
                {
                    Ir("\nEz a lehetőség nem elérhető!");

                    Beszel("Flashback", "Ugyanazt a jelenetet nem vesszük fel kétszer.");
                }
            }

            penz -= 5000;
            alkatresz++;

            Ir("\nTÁPEGYSÉG MEGSZEREZVE! [1/3]");

            Beszel("Büfés", "A következő alkatrész a birodalmi villamosban van.");

            Beszel("Csonka", "És gyros?");

            Beszel("Büfés", "Az külön tizennyolcezer.");

            Beszel("Flashback [narráció]",
                "A költségvetésből sajnos kivágtuk az étkezési jelenetet.");

            Tovabb();

            Ir("===== III. FELVONÁS: A GYURI-INCIDENS =====\n");

            Ir("A villamosállomás bejáratánál igazolványokat ellenőriznek.");

            Beszel("Robot", "Születési ország?");

            Beszel("Csonka", "Én születni Ukrajna.");

            Beszel("Robot", "Ismeretlen ország.");

            Beszel("Csonka", "Akkor te frissíteni adatbázis.");

            Ir("RENDSZERHIBA!");
            Ir("AUTOMATIKUS KITOLONCOLÁS ELRENDELVE.");

            Beszel("Csonka", "HOVA? MINDENHOL LENNI BRITANNIA!");

            Beszel("Robot", "Nyíregyházára.");

            Beszel("Csonka", "NEEEEE!");

            Ir("\nCsonkát elszállítják egy birodalmi buszon.");

            Beszel("Miquel", "Flashback, csinálj valamit!");

            Beszel("Flashback", "Nyugalom. Visszahozzuk.");

            Beszel("Flashback [narráció]",
                "A komédia átmenetileg közigazgatási drámává változott.");

            Tovabb();

            Ir("===== MELLÉKSZÁL: A BEVÁNDORLÁSI HIVATAL =====\n");

            Ir("Flashback és Miquel belép a hivatalba.");

            Ir("Jelenlegi sorszám: 12");
            Ir("A ti sorszámotok: 847");

            Beszel("Miquel", "Engem nem érdekel, megyek Tarkovozni.");

            Beszel("Flashback", "Már megbeszéltük, hogy nincs Tarkov.");

            Beszel("Miquel", "Akkor megyek magot enni.");

            Ir("\nFlashback bal szeme vörösen felizzik.");
            Ir("GEASS AKTIVÁLVA!");

            Beszel("Robot", "A funkció prémium előfizetést igényel.");

            Beszel("Flashback", "Még a természetfeletti erőt is előfizetésessé tették?");

            Beszel("Flashback [narráció]",
                "Lelouch vi Britannia ezt személyes sértésnek venné.");

            Ir("\n1 - Geass próbaidőszak aktiválása");
            Ir("2 - Hivatalos panasz benyújtása");
            Ir("3 - Miquel tárgyal az ügyintézővel");

            do
            {
                Console.Write("\nVálassz: ");
                valasz = Console.ReadLine();

            } while (valasz != "1" && valasz != "2" && valasz != "3");

            if (valasz == "1")
            {
                Ir("\nGEASS: INGYENES PRÓBAIDŐSZAK");

                Beszel("Flashback",
                    "Én, Flashback, megparancsolom: vizsgáld felül Gyuri ügyét!");

                Beszel("Robot", "A határozat hibás. Visszavonva.");
            }
            else if (valasz == "2")
            {
                Ir("\nFlashback benyújtja a panaszt.");

                Ir("A nyomtató 147 példányt készít.");

                Beszel("Robot", "Ez túl sok papírmunka. Inkább javítom a hibát.");

                Beszel("Flashback", "Még a robotok is utálják a bürokráciát.");
            }
            else
            {
                Beszel("Miquel", "ÉN VAGYOK A CSOCSAKI ISTEN!");

                Beszel("Tömeg", "FÚÚÚÚJ!");

                Beszel("Robot", "Rendben! Visszahozzuk Csonkát!");

                Beszel("Robot", "Csak ne kezdjen el énekelni!");
            }

            Ir("\nCsonka visszaérkezik a hivatalba.");

            Beszel("Csonka", "ÉN ÚJRA LENNI LEGÁLIS!");

            Beszel("Miquel", "Milyen volt Nyíregyháza?");

            Beszel("Csonka", "Én nem akar beszélni róla.");

            Beszel("Robot", "Itt vannak az utazási engedélyeik is.");

            Beszel("Flashback [narráció]",
                "Visszakaptuk Gyurit, ráadásul ingyen utazhattunk tovább.");

            Tovabb();

            Ir("===== IV. FELVONÁS: A BIRODALMI VILLAMOS =====\n");

            Ir("A három barát végre felszáll a 2-es villamosra.");

            Beszel("Robot", "Jegyeket, bérleteket!");

            Beszel("Csonka", "NÉZD PAPÍR! NE VINNI NYÍREGYHÁZA!");

            Beszel("Robot", "Rendben van az engedélye.");

            Beszel("Flashback", "A villamos vezérlőchipjéért jöttünk.");

            Beszel("Robot", "Van egy tartalék, de csak intelligens utasoknak adom.");

            Beszel("Miquel", "Én isten vagyok.");

            Beszel("Robot", "Akkor önnek biztosan menni fog.");

            Beszel("Flashback [narráció]",
                "Éreztem, hogy ebből újabb matematikai tragédia lesz.");

            valasz = "";

            while (valasz != "42")
            {
                Beszel("Robot", "Mennyi 6 * 7?");

                Console.Write("Válasz: ");
                valasz = Console.ReadLine();

                if (valasz != "42")
                {
                    Beszel("Robot", "Hibás válasz!");

                    Beszel("Csonka", "Hat meg hét lenni hatvanhét.");

                    Beszel("Miquel", "Az istenek nem számolnak.");

                    Beszel("Flashback [narráció]",
                        "A játékosnak kellett megmentenie a csapat becsületét.");
                }
            }

            alkatresz++;

            Ir("\nVEZÉRLŐCHIP MEGSZEREZVE! [2/3]");

            Beszel("Flashback", "Természetesen tudtam a választ.");

            Beszel("Csonka", "De játékos beírni.");

            Beszel("Flashback", "A negyedik fal az én hatásköröm.");

            Beszel("Robot", "Az utolsó alkatrész a Kolbászkirálynál van.");

            Beszel("Miquel", "Egy rivális istenség?!");

            Beszel("Flashback [narráció]",
                "Végre megérkeztünk a főgonoszhoz.");

            Tovabb();

            Ir("===== V. FELVONÁS: A KOLBÁSZKIRÁLY =====\n");

            Ir("A Nagytemplom helyén egy hatalmas palota áll.");
            Ir("A trónon egy kétméteres, beszélő kolbász ül.");

            Beszel("Király", "Kik merészelnek zavarni?");

            Beszel("Miquel", "A CSOCSAKI ISTEN!");

            Beszel("Tömeg", "FÚÚÚÚJ!");

            Beszel("Király", "Ez meg mi? David Martinez?");

            Beszel("Miquel", "MIÉRT HISZI MINDENKI AZT?!");

            Beszel("Csonka", "Én lenni Gyuri, érvényes papírral.");

            Beszel("Flashback", "Az időkristályért jöttünk.");

            Beszel("Király", "Legyőztök kétszer kő-papír-ollóban, és tiétek.");

            Beszel("Flashback [narráció]",
                "A végső összecsapás egy óvodai játék lett.");

            int gyozelem = 0;

            while (gyozelem < 2)
            {
                Ir("\n---------------------------");
                Ir("Győzelmek: " + gyozelem + "/2");
                Ir("---------------------------");

                Ir("1 - Kő");
                Ir("2 - Papír");
                Ir("3 - Olló");

                Console.Write("\nVálassz: ");
                valasz = Console.ReadLine();

                if (valasz == "1" || valasz == "2" || valasz == "3")
                {
                    int gep = rnd.Next(1, 4);

                    if (gep == 1)
                        Beszel("Király", "KŐ!");
                    else if (gep == 2)
                        Beszel("Király", "PAPÍR!");
                    else
                        Beszel("Király", "OLLÓ!");

                    if ((valasz == "1" && gep == 3) ||
                        (valasz == "2" && gep == 1) ||
                        (valasz == "3" && gep == 2))
                    {
                        gyozelem++;

                        Beszel("Miquel", "ISTENI GYŐZELEM!");

                        Beszel("Tömeg", "FÚÚÚÚJ!");

                        Beszel("Flashback", "Minden a terv szerint.");
                    }
                    else if (valasz == gep.ToString())
                    {
                        Ir("Döntetlen!");

                        Beszel("Csonka", "Kettő nagy agy egyforma.");

                        Beszel("Flashback [narráció]",
                            "A forgatókönyv pillanatnyilag nem haladt.");
                    }
                    else
                    {
                        Ir("A Kolbászkirály nyert!");

                        Beszel("Miquel", "Engem nem érdekel, megyek Tarkovozni.");

                        Beszel("Flashback", "NINCS TARKOV!");

                        Beszel("Miquel", "AKKOR MI VAN?!");

                        Beszel("Csonka", "Kolbász van.");

                        Beszel("Flashback [narráció]",
                            "Ez volt a mélypont. Művészi szempontból kiváló.");
                    }
                }
                else
                {
                    Ir("Érvénytelen választás!");
                }
            }

            alkatresz++;

            Beszel("Király", "Legyőztetek. Tiétek az időkristály.");

            Beszel("Miquel", "TÉRDELJ LE ISTENED ELŐTT!");

            Beszel("Király", "NINCS TÉRDEM, KOLBÁSZ VAGYOK!");

            Beszel("Csonka", "Én kérni mustár hozzá.");

            Beszel("Király", "TAKARODJATOK!");

            Ir("\nIDŐKRISTÁLY MEGSZEREZVE! [3/3]");

            Beszel("Flashback [narráció]",
                "A főgonosz sértetlenül megúszta, Gyuri pedig éhes maradt.");

            Tovabb();

            Ir("===== VI. FELVONÁS: A NAGY FINÁLÉ =====\n");

            Ir("A csapat visszatér az időgéphez.");
            Ir("Alkatrészek: " + alkatresz + "/3");

            for (int i = 1; i <= alkatresz; i++)
            {
                Ir(i + ". alkatrész beszerelve...");
            }

            Ir("\nAZ IDŐGÉP MŰKÖDŐKÉPES!");

            Beszel("Csonka", "Én végre menni otthon?");

            Beszel("Miquel", "Otthon még van Tarkov.");

            Beszel("Flashback", "Hölgyeim és uraim, elérkezett a finálé.");

            Beszel("Csonka", "Te kivel beszélni?");

            Beszel("Flashback", "Senki fontos.");

            Beszel("Flashback [narráció]",
                "Most rajtad áll, kedves játékos, hogyan ér véget a komédiám.");

            Ir("\n1 - Hazatérés 2026-ba");
            Ir("2 - A Csocsaki Birodalom megalapítása");
            Ir("3 - Csonka vezeti az időgépet");
            Ir("4 - Flashback megrendezi a második évadot");

            do
            {
                Console.Write("\nVálassz: ");
                valasz = Console.ReadLine();

            } while (valasz != "1" && valasz != "2" &&
                     valasz != "3" && valasz != "4");

            Console.Clear();

            if (valasz == "1")
            {
                Ir("===== A KLASSZIKUS BEFEJEZÉS =====\n");

                Ir("A három barát visszatér az informatikaórára.");

                Beszel("Tanár", "Hol voltatok?");

                Beszel("Flashback", "Egy hatfelvonásos komédiában.");

                Beszel("Tanár", "És kész a C# feladat?");

                Beszel("Flashback", "Éppen most ért véget.");

                Beszel("Miquel", "Engem nem érdekel, megyek Tarkovozni.");

                Ir("Miquel elindítja a játékot.");
                Ir("FRISSÍTÉS SZÜKSÉGES: 147 GB.");

                Beszel("Miquel", "NEEEEE!");

                Beszel("Flashback [narráció]",
                    "A tökéletes befejezéshez kellett még egy utolsó tragédia.");
            }
            else if (valasz == "2")
            {
                Ir("===== A CSOCSAKI BIRODALOM =====\n");

                Ir("Debrecen önálló várossá válik.");
                Ir("Miquel lesz a város vezetője.");
                Ir("Flashback irányítja a színházat.");
                Ir("Csonka a bevándorlási hivatalban dolgozik.");

                Beszel("Miquel", "ÉLJEN A CSOCSAKI ISTEN!");

                Beszel("Tömeg", "FÚÚÚÚJ!");

                Beszel("Csonka", "Minden ember kapni papír!");

                Beszel("Miquel", "Első intézkedésem: hozzátok vissza a Tarkovot!");

                Beszel("Flashback [narráció]",
                    "Így született meg a történelem első szotyolaalapú gazdasága.");
            }
            else if (valasz == "3")
            {
                Ir("===== A GYURI-PARADOXON =====\n");

                Beszel("Flashback", "Gyuri, írd be, hogy 2026.");

                Beszel("Csonka", "Én profi gépkezelő!");

                Ir("\nCÉLÁLLOMÁS: DEBRECEN, 2206.");

                Beszel("Miquel", "GYURI!");

                Beszel("Csonka", "Ugyanaz számok, csak más sorrend.");

                Beszel("Flashback [narráció]",
                    "A folytatás jogait már útközben értékesítettem.");
            }
            else
            {
                Ir("===== A MÁSODIK ÉVAD =====\n");

                Beszel("Flashback", "Kedves nézőink! Köszönöm a figyelmet.");

                Beszel("Miquel", "Megint kivel beszélsz?");

                Beszel("Csonka", "Ő lenni bolond?");

                Beszel("Flashback", "Én rendezem a következő évadot.");

                Ir("Az időgép bekapcsol.");

                Ir("\nÚJ CÉLÁLLOMÁS: MISKOLC, 2099.");

                Beszel("Miquel", "Inkább maradjunk Debrecenben!");

                Beszel("Csonka", "Én felmondani!");

                Beszel("Flashback [narráció]",
                    "A komédia folytatódik. A költségvetés továbbra is nevetséges.");
            }


            Tovabb();

            Ir("================================");
            Ir("           STÁBLISTA");
            Ir("================================\n");

            Ir("Főszereplő: Flashback");
            Ir("Rendező: Flashback");
            Ir("Narrátor: Flashback");
            Ir("Csocsaki Isten: Miquel");
            Ir("Bevándorlási szakértő: Csonka");
            Ir("Főgonosz: Kolbász");
            Ir("Legnagyobb veszteség: Tarkov");

            Ir("\nMaradék költségvetés: " + penz + " Ft");

            Beszel("Flashback", "Minden a komédia része volt, bármilyen egyezés a valósággal csupán családi csomagolás.");

            Beszel("Csonka", "Én nem kapni fizetés?");

            Beszel("Flashback [narráció]", "Függöny.");

            Ir("\n========== VÉGE ==========");

            Console.ReadKey();
        }
    }
}