using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Maker
{
    enum GenderList
    {
        M, F, Other
    }

    enum MaleNames
    {
        //271 names
        Aaryn, Aaro, Aarus, Abramus, Abrahm, Abyl, Abelus, Adannius, Adanno, Aedam, Adym, Adamus, Aedrian, Aedrio, Aedyn, Aidyn, Aelijah, Elyjah, Aendro, Androe, Aenry, Hynroe, Hynrus, Aethan, Aethyn, Aevan, Evyn, Evanus, Alecks, Alyx, Alexandyr, Xandyr, Alyn, Alaen, Andrus, Aendrus, Anglo, Aenglo, Anglus, Antony, Antonyr, Astyn, Astinus, Axelus, Axyl, Benjamyn, Benjamyr, Braidyn, Brydus, Braddeus, Brandyn, Braendyn, Bryus, Bryne, Bryn, Branus, Caeleb, Caelyb, Caerlos, Carlus, Cameryn, Camerus, Cartus, Caertero, Charlus, Chaerles, Chyrles, Christophyr, Christo, Chrystian, Chrystan, Connorus, Connyr, Daemian, Damyan, Daenyel, Danyel, Davyd, Daevo, Dominac, Dylaen, Dylus, Elius, Aeli, Elyas, Helius, Helian, Emilyan, Emilanus, Emmanus, Emynwell, Ericus, Eryc, Eryck, Ezekius, Zeckus, Ezekio, Ezrus, Yzra, Gabrael, Gaebriel, Gael, Gayl, Gayel, Gaeus, Gavyn, Gaevyn, Goshwa, Joshoe, Graysus, Graysen, Gwann, Ewan, Gwyllam, Gwyllem, Haddeus, Hudsyn, Haesoe, Haesys, Haesus, Handus, Handyr, Hantus, Huntyr, Haroldus, Haryld, Horgus, Horus, Horys, Horyce, Hosea, Hosius, Iaen, Yan, Ianus, Ivaen, Yvan, Jaecoby, Jaecob, Jaeden, Jaedyn, Jaeremiah, Jeremus, Jasyn, Jaesen, Jaxon, Jaxyn, Jaxus, Johnus, Jonus, Jonaeth, Jonathyn, Jordus, Jordyn, Josaeth, Josephus, Josaeus, Josayah, Jovanus, Giovan, Julyan, Julyo, Jyck, Jaeck, Jacus, Kaevin, Kevyn, Vinkus, Laevi, Levy, Levius, Landyn, Laendus, Leo, Leonus, Leonaerdo, Leonyrdo, Lynardus, Lincon, Lyncon, Linconus, Logaen, Logus, Louis, Lucius, Lucae, Lucaen, Lucaes, Lucoe, Lucus, Lyam, Maeson, Masyn, Maetho, Mathoe, Matteus, Matto, Maxus, Maximus, Maximo, Maxymer, Mychael, Mygwell, Miglus, Mythro, Mithrus, Naemo, Naethyn, Nathanus, Naethynel, Nicholaes, Nycholas, Nicholys, Nicolus, Nolyn, Nolanus, Olivyr, Alivyr, Olivus, Oscarus, Oscoe, Raen, Ryn, Robertus, Robett, Bertus, Romyn, Romanus, Ryderus, Ridyr, Samwell, Saemuel, Santegus, Santaegus, Sybasten, Bastyen, Tago, Aemo, Tagus, Theodorus, Theodus, Thaeodore, Thomys, Thomas, Tommus, Tylus, Tilyr, Uwyn, Oewyn, Victor, Victyr, Victorus, Vincynt, Vyncent, Vincentus, Wyttus, Wyaett, Xavius, Havius, Xavyer, Yago, Tyago, Tyego, Ysaac, Aisaac, Ysaiah, Aisiah, Siahus, Zacharus, Zachar, Zachaery
    }

    enum FemaleNames
    {
        //153 names
        Abigayl, Aebria, Aeobreia, Breia, Aedria, Aodreia, Dreia, Aeliya, Aliya, Aella, Aemilya, Aemma, Aemy, Amy, Ami, Aeria, Arya, Aeva, Aevelyn, Evylann, Alaexa, Alyxa, Alina, Aelina, Aelinea, Allisann, Allysann, Alyce, Alys, Alysea, Alyssia, Aelyssa, Amelya, Maelya, Andreya, Aendrea, Arianna, Aryanna, Arielle, Aryell, Ariella, Ashlena, Aurora, Avaery, Avyrie, Bella, Baella, Brooklinea, Bryanna, Brynna, Brinna, Caemila, Chloe, Chloeia, Claira, Clayre, Clayra, Delyla, Dalyla, Elisybeth, Aelisabeth, Ellia, Ellya, Elyana, Eliana, Eva, Falyne, Genaesis, Genaesys, Gianna, Jianna, Janna, Graece, Grassa, Haenna, Hanna, Halya, Harperia, Peria, Hazyl, Hazel, Jasmyne, Jasmine, Jocelyne, Joceline, Celine, Kaelia, Kaelya, Kathryne, Kathrine, Kayla, Kaila, Kymber, Kimbera, Layla, Laylanna, Leia, Leya, Leah, Lilia, Lylia, Luna, Maedisa, Maelania, Melania, Maya, Mya, Myla, Milae, Naomi, Naome, Natalya, Talya, Nathylie, Nataliae, Thalia, Nicola, Nikola, Nycola, Olivya, Alivya, Penelope, Paenelope, Pynelope, Rianna, Ryanna, Ruby, Ryla, Samaentha, Samytha, Sara, Sarah, Savannia, Scarletta, Sharlotta, Caerlotta, Sophya, Stella, Stylla, Valentyna, Valerya, Valeria, Valia, Valea, Victorya, Vilettia, Ximena, Imaena, Ysabel, Zoe, Zoeia, Zoea, Zoesia
    }

    enum OtherNames
    {
        //361 names
        Ace, Adrian, Aiden, Ainsleigh, Ainsley, Ainslie, Alex, Alexis, Allie, Ally, Alta, Amari, Andi, Andie, Andy, Angel, Arden, Ari, Ariel, Armani, Ash, Ashe, Ashley, Ashton, Aspen, Aubrey, Auburn, Aude, Audie, August, Averi, Avery, Ayden, Bailee, Bailey, Baylee, Billie, Billy, Blair, Bobbie, Bobby, Brayden, Briggs, Brook, Brooklyn, Brynn, Caden, Cadence, Cady, Caiden, Cam, Camden, Camdyn, Cameron, Campbell, Camron, Camryn, Carlen, Carmen, Carson, Carter, Casey, Cassidy, Cayden, Cedar, Charlie, Chey, Chris, Cobie, Coby, Codie, Cody, Corey, Corrie, Cory, Cyan, Cyd, Cypress, Cyprus, Dakota, Dale, Dallas, Dana, Dani, Dannie, Danny, Darci, Darcy, Darrell, Darryl, Delaney, Demi, Demy, Devan, Devin, Devyn, Diamond, Dominique, Dorian, Drew, Dusty, Dylan, Easton, Eden, Elisha, Ellery, Elliot, Ellis, Elly, Ember, Embry, Emerson, Emery, Emory, Eris, Esme, Fae, Fen, Fenn, Fin, Finley, Finn, Florence, Forrest, Fox, Fran, Frances, Gabbi, Gabby, Genesis, Gerrie, Gerry, Gris, Hailey, Haley, Halie, Halley, Harlen, Harlow, Harper, Hartley, Hayden, Haylee, Hayley, Hilary, Hollis, Hunter, Iggy, Indigo, Ira, Izzy, Jackie, Jade, Jaiden, Jaidyn, Jaime, Jaimie, Jamie, Jan, Jay, Jaydan, Jayden, Jaydin, Jaydyn, Jaylin, Jayme, Jean, Jerrie, Jerry, Jess, Jesse, Jessie, Jett, Jo, Jody, Joe, Joey, Jonnie, Jude, Juniper, Justice, Kacey, Kacie, Kaden, Kai, Kaiden, Kam, Kameron, Kamron, Karter, Kasey, Kay, Kayden, Kaylin, Kelly, Kelsey, Kelsie, Kendall, Kerri, Kerry, Kirby, Kit, Kodi, Kory, Kris, Krishna, Kristen, Ky, Kye, Kyle, Kyrie, Lacy, Lain, Landry, Lane, Larkin, Laurel, Lauren, Leaf, Lee, Leighton, Lennon, Lennox, Lesley, Leslie, Lin, Lindsay, Linn, Logan, London, Londyn, Lonnie, Loren, Lou, Lowe, Luan, Luca, Lyn, Lynn, Mackenzie, Madison, Mallory, Marin, Marion, Marley, Marlowe, Mars, Mason, Meadow, Mel, Meredith, Merrill, Micah, Micki, Mika, Mischa, Misha, Morgan, Neely, Nicki, Nico, Nikko, Niko, Nova, Paige, Paisley, Parker, Pat, Pax, Payton, Peyton, Phoenix, Piper, Presley, Quinn, Rae, Rain, Raine, Rainn, Raven, Ray, Reagan, Reese, Reilly, Remi, Remington, Remy, Rémy, Rey, Riley, River, Robbie, Robin, Rogue, Rory, Ryan, Rylan, Rylee, Ryley, Sage, Salix, Sam, Sammie, Sammy, Sandi, Sandy, Santana, Sasha, Sawyer, Scout, Seneca, Shannon, Shay, Shea, Shelley, Sky, Skylar, Skyler, Slater, Spencer, Stacy, Stevie, Storm, Syd, Sydney, Tash, Tate, Tatum, Tay, Tayler, Taylor, Teagen, Teal, Terra, Terry, Tobin, Tommie, Toni, Tony, Tori, Torrey, Tory, Tracey, Traci, Tracy, Tristen, Tyler, Val, Valentine, Viv, Vivian, Whitney, Willow, Xan, Xander, Yael, Zan, Zane, Zephyr, Zoe, Zoey
    }


    class Base
    {
        public string Name;
        public MaleNames MName;
        public FemaleNames FName;
        public OtherNames OName;
        public GenderList Gender;

    }


}
