using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro1,
        intro2,
        Choose,
        Choosespelen,
        Choosenietspelen,
        wandelen,
        koken,
        buiten,
        kamer,
        schuur,
        verhaalkamer,
        verhaalschuur,
        rennen,
        negeren,
        beneden,
        boven,
        verdwaalt,
        verhaalboven,
        auto,
        zoeken,
        autochoice,
        dood,
        autochoiceblijven,
        autochoicelopen,
        grotverhaal,
        grotlinks,
        grotrecht,
        kastverhaal,
        eindeleven,
        SURVIVED,
        eindedood,
        SURVIVED2
    }

    private States currentState = States.start;


    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Until Dawn");
        Terminal.WriteLine("Dit is gebaseerd op een Horror game");
        Terminal.WriteLine("Type Start om te beginnen");
    }

    void StartIntro()
    {
        currentState = States.intro1;
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was koude nacht met je vrienden");
        Terminal.WriteLine("Jullie dachten het was een goed idee om een hutje in het bos te huren");
        Terminal.WriteLine("Jullie hebben op het nieuws gehoord dat het heftig zou gaan sneeuwen tot s'morgens");
        Terminal.WriteLine("Type V om te zien wat er nu gebeurd");
    }

    void StartIntro2()
    {
        currentState = States.intro2;
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "Het is nu 7 uur en de jongens dachten dat het een goed idee was om een spelletje te spelen");
        Terminal.WriteLine("ze dachten dat het leuk zal zijn om  te spellen");
        Terminal.WriteLine("Maar je weet niet of wel of niet mee doen ");
        Terminal.WriteLine("Type V om te zien wat er nu gaat gebeuren");
    }

    void StartChoose()
    {
        currentState = States.Choose;
        Terminal.ClearScreen();
        Terminal.WriteLine("Nu denk je zal ik mee spelen of niet?");
        Terminal.WriteLine("Kies snel want anders beginnen ze zonder jou met het spelen");
        Terminal.WriteLine("Kies spelen of niet spelen");
    }

    void StartChoosespelen()
    {
        currentState = States.Choosespelen;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besloot om mee te doen");
        Terminal.WriteLine("Daryn begint te tellen");
        Terminal.WriteLine("Nu dat je mee doet moet je zo snel mogelijk kiezen waar je gaat verstoppen");
        Terminal.WriteLine("je hebt nu 3 keuzes binnen bij de schuur of buiten");
        Terminal.WriteLine("Type Buiten, kamers of schuur");
    }

    void StartChoosenietspelen()
    {
        currentState = States.Choosenietspelen;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je wilt niet mee doen omdat het een dom spel is");
        Terminal.WriteLine("Nu zit je alleen op de bank en weet niet wat je nu gaat doen");
        Terminal.WriteLine("Je hebt 2 keuzes om te gaan wandelen of je gaat koken omdat je honger hebt ");
        Terminal.WriteLine("Type wandelen of koken");
    }

    void Startwandelen()
    {
        currentState = States.wandelen;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt besloten om te gaan wandelen ook al is het aan het sneeuwen");
        Terminal.WriteLine("Je kijkt rond om te zien wat je allemaal kan doen");
        Terminal.WriteLine("Uit het niets gaan de lichten uit en denk je dat het Jack grapjes probeert uit te halen");
        Terminal.WriteLine("Je gaat naar de fuse kast om te kijken wat er aan de hand is");
        Terminal.WriteLine("Wanneer je een van de stroom schakelaars probeert aan te raken");
        Terminal.WriteLine("Word je door een hele hoge stroom geschokken");
        Terminal.WriteLine("Type V om te kijken wat er nu gebeurd");
    }

    void Startkoken()
    {
        currentState = States.koken;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt Noodels gekookt omdat je honger hebt");
        Terminal.WriteLine("nu ben je rustig aan het eten en dan");
        Terminal.WriteLine("Opeens ruik je de geur van gas en denkt na of je well alles afgesloten had");
        Terminal.WriteLine("nu sta je op om te kijken wat zo ruikt kijkt in de spiegel en ziet iemand achter je staan");
        Terminal.WriteLine("Hij speelt livantlic de mixtape ( want het is SUPAH FIYAH ) en... ");
        Terminal.WriteLine("Type V om te zien wat er nu gebeurd");
    }

    void Startdood()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt de verkeerde keuze(s) gemaakt en bent nu DOOD!");
    }

    void Startbuiten()
    {
        currentState = States.buiten;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je dacht dat het beter was om buiten te verstoppen");
        Terminal.WriteLine("Nu dat je buiten bent zoek je met spoed naar een goede plek om te verstoppen");
        Terminal.WriteLine("Uit het niets hoor je voetstappen maar");
        Terminal.WriteLine("Het kan Daryn niet zijn want die is nog aan het tellen");
        Terminal.WriteLine("Nu ligt het aan jou de keuze om deze stappen te negeren of weg te rennen");
        Terminal.WriteLine("Type niet negeren of rennen");
    }


    void Startkamer()
    {
        currentState = States.kamer;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt besloten om in een kamer te gaan verstoppen ");
        Terminal.WriteLine("Nu zit je te denken of je onder een bed of in de kast zou gaan ");
        Terminal.WriteLine("Je kijkt in de spiegel en kijkt voor een paar seconden naar jezelf");
        Terminal.WriteLine("Toevalig is er iemand achter die one way spiegel ");
        Terminal.WriteLine("Type V om verder te gaan ");
    }

    void Startschuur()
    {
        currentState = States.schuur;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besloot om in de schuur te gaan verstoppen");
        Terminal.WriteLine("Je kan niks zien omdat het donker in de schuur is ");
        Terminal.WriteLine("Wanneer je het licht aan doet zie je allemaal bloedige messen en wapens");
        Terminal.WriteLine("Je vind het raar en wilt zo snel mogelijk iets tegen de groep vertellen");
        Terminal.WriteLine("Je schrikt van een vleermuis die opeens naar binnen vliegt en valt op de grond");
        Terminal.WriteLine("Type V om verder te gaan");
    }

    void Startverhaalkamer()
    {
        currentState = States.verhaalkamer;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besloot om in de kast te gaan verstoppen");
        Terminal.WriteLine("Je wist niet dat die persoon uit de spiegel kwam");
        Terminal.WriteLine("En nu voor de kast staat");
        Terminal.WriteLine("Uit het niets hoor je geklop op de kast deur waar je aan het schuilen bent");
        Terminal.WriteLine("Je dacht dat Daryn jou had gevonden en doet de deur voorzichtig open");
        Terminal.WriteLine("Type V om door te gaan");
    }

    void Startverhaalschuur()
    {
        currentState = States.verhaalschuur;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je probeert op te staan en ziet een mes in je been ");
        Terminal.WriteLine("Je kruipt weg want door de pijn kan je niet lopen");
        Terminal.WriteLine("Je komt bij de deur mat aan en ziet een geheime ingang onder de mat");
        Terminal.WriteLine("Je merkt dat het ondergronds leidt");
        Terminal.WriteLine("Je kan nu kiezen om hier te blijven of naar beneden te gaan");
        Terminal.WriteLine("Type blijven of beneden ");
    }

    void Startnegeren()
    {
        currentState = States.negeren;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je negeert de voetstappen en blijft lopen");
        Terminal.WriteLine("Je hoort de voetstappen dicht bij komen ");
        Terminal.WriteLine("Nu hoor je de voetstappen heel dicht achter je en begint zenuwachtig te worden");
        Terminal.WriteLine("Door de angst begin je toch te rennen");
        Terminal.WriteLine("Type V om verder te gaan");
    }

    void Startrennen()
    {
        currentState = States.rennen;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je begint zo snel mogelijk te rennen");
        Terminal.WriteLine("Je rent tot dat je bij een grot terecht komt");
        Terminal.WriteLine("En besloot naar binnen te gaan ");
        Terminal.WriteLine("Type V om verder te gaan");
    }

    void Startbeneden()
    {
        currentState = States.beneden;
        Terminal.ClearScreen();
        Terminal.WriteLine("je besloot om naar beneden te gaan ");
        Terminal.WriteLine("Met die mes in je been is het een klein beetje moeilijk om te bewegen ");
        Terminal.WriteLine("Je pakt je riem en zet em strak om je been heen en haalt het mes eruit");
        Terminal.WriteLine("Nu loop je de trap naar beneden maar het is te donker om iets te zien");
        Terminal.WriteLine("Je pakt je telefoon om de zaklamp aan te doen maar ziet niet dat de trap kapot is en valt");
        Terminal.WriteLine("Type V om verder te gaan");
    }

    void Startboven()
    {
        currentState = States.boven;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besloot om boven te blijven maar je kan niet ver gaan met die mes in je been");
        Terminal.WriteLine("Je zet die riem strak om je been en haalt het mes eruit");
        Terminal.WriteLine(
            "Je wilt naar buiten gaan maar omdat het zo hard aan het sneeuwen is, is het moeilijk om iets te doen  ");
        Terminal.WriteLine("Je wilt iemand uit de groep bellen maar je ziet dat je door de storm geen bereik hebt ");
        Terminal.WriteLine("Type V om verder te gaan");
    }

    void Startverdwaalt()
    {
        currentState = States.verdwaalt;
        Terminal.ClearScreen();
        Terminal.WriteLine("Wanneer je wakker wordt merk je dat je op een lijk ligt");
        Terminal.WriteLine("Je gebruikt de zaklamp van je telefoon en merkt dat Shawn daar dood ligt");
        Terminal.WriteLine("Door de schok weet je niet wat je moet doen");
        Terminal.WriteLine("Nu probeer je zo snel mogelijk de trap weer op te gaan maar merkt dat de deur dicht is");
        Terminal.WriteLine("Nu probeer je een op een andere manier te denken om hier uit te komen");
        Terminal.WriteLine("Type v om door te gaan");
    }

    void Startverhaalboven()
    {
        currentState = States.verhaalboven;
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "Na een tijdje begin je last van je been te krijgen en moet je echt naar buiten gaan anders ga je dood");
        Terminal.WriteLine("Ook al heb je die riem om je been je bloed nog steeds veel");
        Terminal.WriteLine(
            "Nu moet je kiezen om je vrienden groep te zoeken of je verlaat hun door naar de auto te gaan");
        Terminal.WriteLine("Type zoeken of auto");
    }

    void Startauto()
    {
        currentState = States.auto;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besloot om naar de auto te gaan");
        Terminal.WriteLine("Buiten is het vriezend koud");
        Terminal.WriteLine("Je bent bijna bij de auto maar de kou word steeds erger");
        Terminal.WriteLine("Je komt aan en zit in de auto je probeert het te starten maar er gebeurd niks");
        Terminal.WriteLine(
            "Wat je niet heb gemerkt is dat iemand de benzine slang geknipt heeft en alle benzine zit nu rond de auto");
        Terminal.WriteLine("Je kijkt voor je en je ziet iemand in de verte met een lighter ");
        Terminal.WriteLine("Hij gooit de light die aanstaat naar de auto toe en...");
        Terminal.WriteLine("Type V om verder te gaan");
    }

    void Startzoeken()
    {
        currentState = States.zoeken;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besloot om naar de auto te gaan");
        Terminal.WriteLine("Buiten is het vriezend koud");
        Terminal.WriteLine("Je bent in huis en roept naar je vrienden groep maar je krijgt geen antwoord terug");
        Terminal.WriteLine("Je loopt de kamer binnen en ziet Micheal dood liggen op bed");
        Terminal.WriteLine("Nu haast je snel naar de woonkamer en je ziet dat Daryn ook dood op de bank ligt");
        Terminal.WriteLine("Je besloot om naar de auto te gaan want je kon Shawn niet vinden ");
        Terminal.WriteLine("Type V om door te gaan ");
    }

    void Startautochoice()
    {
        currentState = States.autochoice;
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "Nu zit je in de auto en probeert een manier te zoeken om weg te gaan want alle wegen zijn gevuld met sneeuw");
        Terminal.WriteLine("Dan herinner je dat er een huis niet zo ver van hier is ");
        Terminal.WriteLine("Je doet de auto aan en rijdt zo snel mogelijk die richting op");
        Terminal.WriteLine("Halfverwegen stop de auto en merk je dat er geen benzine meer in zit");
        Terminal.WriteLine("Nu moet je de keuze kiezen om te gaan lopen of in de auto blijf wachten");
        Terminal.WriteLine("Type lopen of wachten");
    }

    void Startautochoiceblijven()
    {
        currentState = States.autochoiceblijven;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besloot om in de auto te blijven");
        Terminal.WriteLine("Maar door de bloed die je verloren hebt kan je moeilijk bij blijven");
        Terminal.WriteLine("Wat je nog herinnert als laatste is dat je 2 dagen zou moeten wachten ");
        Terminal.WriteLine("Na die 2 dagen is de storm officieel voorbij");
        Terminal.WriteLine("Je valt flauw en word na anderhalve dag wakker ");
        Terminal.WriteLine("Je zit in de auto van de locale politie en wordt naar het ziekenhuis gebracht");
        Terminal.WriteLine("Type V om verder te gaan");
    }

    void Startautochoicelopen()
    {
        currentState = States.autochoicelopen;
        Terminal.ClearScreen();
        Terminal.WriteLine("je hebt besloten om toch te gaan lopen");
        Terminal.WriteLine("Na een paar uren kan je niet meer tegen de kou en door all dat bloed dat je verloren hebt");
        Terminal.WriteLine("val je op de grond en je hebt nauwlijks de kracht om nog te schreeuwen");
        Terminal.WriteLine("Type V om door te gaan");
    }

    void Startgrotverhaal()
    {
        currentState = States.grotverhaal;
        Terminal.ClearScreen();
        Terminal.WriteLine("Nu dat je in de grot bent hoor je de voetstappen niet meer");
        Terminal.WriteLine("Je voelt je nu veilig en begint de grot te onderzoeken");
        Terminal.WriteLine("je pakt je telefoon en gebruikt het als zaklamp");
        Terminal.WriteLine("Je begint na een paar uren lopen te merken dat je de weg bent kwijt geraakt");
        Terminal.WriteLine("Nu zie je een splitsing en je kan kiezen om rechts of links te gaan");
        Terminal.WriteLine("welke kant kies je?");
        Terminal.WriteLine("Type links of rechts");
    }

    void Startgrotlinks()
    {
        currentState = States.grotlinks;
        Terminal.ClearScreen();
        Terminal.WriteLine("je besloot om naar links te gaan");
        Terminal.WriteLine("Je ziet een hele groep met vleermuizen en probeert zo stil mogelijk te zijn");
        Terminal.WriteLine("Uit het niets hoor je de voetstappen weer");
        Terminal.WriteLine(
            "Van de angst begin je te rennen maar je merkt dat je iedere keer op de zelfde plek terug komt te staan");
        Terminal.WriteLine("Dus in plaats van links ga je rechts");
        Terminal.WriteLine("Type V om door te gaan");
    }

    void Startgrotrecht()
    {
        currentState = States.grotrecht;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besloot om naar rechts te gaan");
        Terminal.WriteLine("Na een tijdje lopen hoor je de voetstappen nog een keer");
        Terminal.WriteLine("Maar nu weet je niet van welke kant het precies komt");
        Terminal.WriteLine("Je rent zo snel mogelijk door de grot en ziet in de verte een uitgang");
        Terminal.WriteLine("Opeen begint de grot in elkaar te vallen");
        Terminal.WriteLine("Nu dat je bij de ingang nadert merkdat er over all bommen waren geplaatst en...");
        Terminal.WriteLine("Type V om door te gaan");
    }

    void Startkastverhaal()
    {
        currentState = States.kastverhaal;
        Terminal.ClearScreen();
        Terminal.WriteLine("Toen je de deur open hebt ge daan schrik je");
        Terminal.WriteLine("Je ziet iemand met een (miedu) mask en weet niet wat te doen ");
        Terminal.WriteLine("hij heeft een mes in zijn had ");
        Terminal.WriteLine("je gooi iets op hem en probeer weg te rennen maar hij hou je vast");
        Terminal.WriteLine("je vecht en vecht maar hij zet de mes in je buik");
        Terminal.WriteLine("Je kan niks meer doen en naa een paar minute gaat de persoon je doden");
        Terminal.WriteLine("Type V om door te gaan");
    }

    void Starteindeleven()
    {
        currentState = States.eindeleven;
        Terminal.ClearScreen();
        Terminal.WriteLine("je doet je ogen op en ziet dat je opeens in het ziekenhuis bent");
        Terminal.WriteLine("Je vraagt je af hoe je daar bent gekomen ");
        Terminal.WriteLine("je herinnert je bijna niks meer van wat er allemaal is gebeurd");
        Terminal.WriteLine("Je vraagt aan de politie die daar nog was wat er is gebeurd met je vrienden groep");
        Terminal.WriteLine("en zij dat ze allemaal dood zijn er dat er zelfs eentje mist");
        Terminal.WriteLine("Nu komt de zuster die jou een soort vaccine wilt geven");
        Terminal.WriteLine("Maar je vertrouwd het niet laat je haar die vaccine aan je geven of niet");
        Terminal.WriteLine("Type wel of niet");
    }

    void Starteindedood()
    {
        currentState = States.eindedood;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je besloot om niks te doen ");
        Terminal.WriteLine("Ze zet het spuitje in je systeem en zegt slaaplekker");
        Terminal.WriteLine(
            "voordat je in slaap valt zeg je tegen haar om jou te laten weten wanneer ze iets van de verloren vriend hoort");
        Terminal.WriteLine("Ze laat weten dat de enige die nog mist ben ik die nog Dood moet gaan");
        Terminal.WriteLine("Om de groep kompleet te maken");
        Terminal.WriteLine("Het duurde niet lang en nu gaan je ogen dicht....");
        Terminal.WriteLine("Type V om verder te gaan");
    }

    void StartSURVIVED()
    {
        currentState = States.SURVIVED;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt haar die vaccine niet aan jou laten geven");
        Terminal.WriteLine("De politie komt op je checken en je laat weten dat je de zuster niet vertrouwd");
        Terminal.WriteLine("De politie laat gelijk weten dat ze jou probeerde te vergiftigen met een sterke gif");
        Terminal.WriteLine("Je leeft nog een dag en valt in slaap na alle stress");
        Terminal.WriteLine("Type E om door te gaan");
    }

    void StartSURVIVED2()
    {
        currentState = States.SURVIVED2;
        Terminal.ClearScreen();
        Terminal.WriteLine("You made the right choices and survived Good Job je bent een echte STRIJDER!");
    }


    void OnUserInput(string input)
    {
        if (currentState == States.start)
        {
            if (input == "Start")
            {
                StartIntro();
            }
            else if (input == "start")
            {
                Terminal.WriteLine("het s met hoofd letter");
            }
        }
        else if (currentState == States.intro1)
        {
            if (input == "V")
            {
                StartIntro2();
            }
        }
        else if (currentState == States.intro2)
        {
            if (input == "V")
            {
                StartChoose();
            }
        }
        else if (currentState == States.Choose)
        {
            if (input == "niet spelen")
            {
                StartChoosenietspelen();
            }
            else if (input == "spelen")
            {
                StartChoosespelen();
            }
        }
        else if (currentState == States.Choosenietspelen)
        {
            if (input == "wandelen")
            {
                Startwandelen();
            }
            else if (input == "koken")
            {
                Startkoken();
            }
        }
        else if (currentState == States.wandelen)
        {
            if (input == "V")
            {
                Startdood();
            }
        }
        else if (currentState == States.koken)
        {
            if (input == "V")
            {
                Startdood();
            }
        }
        else if (currentState == States.Choosespelen)
        {
            if (input == "buiten")
            {
                Startbuiten();
            }
            else if (input == "kamer")
            {
                Startkamer();
            }
            else if (input == "schuur")
            {
                Startschuur();
            }
        }
        else if (currentState == States.buiten)
        {
            if (input == "negeren")
            {
                Startnegeren();
            }
            else if (input == "rennen")
            {
                Startrennen();
            }
        }
        else if (currentState == States.negeren)
        {
            if (input == "V")
            {
                Startrennen();
            }
        }
        else if (currentState == States.rennen)
        {
            if (input == "V")
            {
                Startgrotverhaal();
            }
        }
        else if (currentState == States.grotverhaal)
        {
            if (input == "rechts")
            {
                Startgrotrecht();
            }
            else if (input == "links")
            {
                Startgrotlinks();
            }
        }
        else if (currentState == States.grotlinks)
        {
            if (input == "V")
            {
                Startgrotrecht();
            }
        }
        else if (currentState == States.grotrecht)
        {
            if (input == "V")
            {
                Startdood();
            }
        }
        else if (currentState == States.kamer)
        {
            if (input == "V")
            {
                Startverhaalkamer();
            }
        }
        else if (currentState == States.verhaalkamer)
        {
            if (input == "V")
            {
                Startkastverhaal();
            }
        }
        else if (currentState == States.kastverhaal)
        {
            if (input == "V")
            {
                Startdood();
            }
        }
        else if (currentState == States.schuur)
        {
            if (input == "V")
            {
                Startverhaalschuur();
            }
        }
        else if (currentState == States.verhaalschuur)
        {
            if (input == "blijven")
            {
                Startboven();
            }
            else if (input == "beneden")
            {
                Startbeneden();
            }
        }
        else if (currentState == States.beneden)
        {
            if (input == "V")
            {
                Startverdwaalt();
            }
        }
        else if (currentState == States.boven)
        {
            if (input == "V")
            {
                Startverhaalboven();
            }
        }
        else if (currentState == States.verhaalboven)
        {
            if (input == "zoeken")
            {
                Startzoeken();
            }
            else if (input == "auto")
            {
                Startauto();
            }
        }
        else if (currentState == States.zoeken)
        {
            if (input == "V")
            {
                Startautochoice();
            }
        }
        else if (currentState == States.auto)
        {
            if (input == "V")
            {
                Startautochoice();
            }
        }
        else if (currentState == States.autochoice)
        {
            if (input == "lopen")
            {
                Startautochoicelopen();
            }
            else if (input == "wachten")
            {
                Startautochoiceblijven();
            }
        }
        else if (currentState == States.autochoicelopen)
        {
            if (input == "V")
            {
                Startdood();
            }
        }
        else if (currentState == States.autochoiceblijven)
        {
            if (input == "V")
            {
                Starteindeleven();
            }
        }
        else if (currentState == States.eindeleven)
        {
            if (input == "wel")
            {
                StartSURVIVED();
            }
            else if (input == "niet")
            {
                Starteindedood();
            }
        }
        else if (currentState == States.eindedood)
        {
            if (input == "V")
            {
                Startdood();
            }
        }
        else if (currentState == States.SURVIVED)
        {
            if (input == "E")
            {
                StartSURVIVED2();
            }
        }
    }
} 

