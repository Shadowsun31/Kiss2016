using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class S_TextGenerator : MonoBehaviour {

    private string[] listName = {
        "Salam", "Taysar", "Samir", "Ayman", "Ramy", "Sami", "Bassem", "Farouk", "Marwan", "Charbel", "Mohamed" ,"Shadi", "Hassan", "Ibrahim", "Atef", "Assia", "Liliane", "Nawal", "Yara", "Mouna", "Sofia", "Julia", "Razane", "Chada", "Aya", "Hayfa", "Leila", "Nasrine", "Samaya", "Samia", "Shérine", "Yasmine", "Zéna", "Raïssa", "Maysam", "Abdulla", "Ako", "Ali", "Andric", "Claas", "Dung", "Eby", "Duyên", "Faryal", "Khan", "Abena", "Andrea", "Anggi", "Andreina", "Elvira", "Elly", "Dragana", "Farahnaz", "Mina", "Mariam", "Zyad", "Zaïm", "Younes", "Youcef", "Tarik", "Siham", "Samir", "Salim", "Sayed", "Razi", "Omar", "Osmane", "Nahil", "Zainab", "Sara", "Lana", "Zohra", "Zeïna", "Zineb", "Zayane", "Yamina", "Soraya", "Sonia", "Samia", "Rosa", "Nour", "Nezha", "Nora"
    };

    private string[] listReasons = {
       " ne peut plus rigoler là où il se trouve.",
       " pleure la mort de sa maman tous les soirs.", 
       " ne rejoindra jamais ses enfants.",
       " a eu moins de chance que lors du bombardement de son village.",
       " aurait bien eu besoin de ses deux jambes pour nager.",
       " a survécu pour être renvoyé dans son pays 1 mois plus tard.",
       " attend toujours sa famille.",
       " cherche encore son fils : Walid.",
       " a vu son mari se noyer sous ses yeux.",
       " était presque arrivé avant de boire la tasse.",
       " n'a plus soif!",
       " est mort d'épuisement sur la plage.",
       " aurait mieux fait de ne pas sécher les cours de natation.",
       " avait toujours voulu voir la mer",
       " aura servi de garde-manger aux poissons.",
       " est maintenant devenu plongeur professionnel.",
       " donne à manger aux requins.",
       " mange les algues par les racines.",
       " joue maintenant aux cartes avec Jack.", 
       " passera peut être aux informations ce soir.",
       " a toujours voulu avoir son nom au journal.",
       " est en bonne voie de découvrir l'Atlantide.",
       " restera vierge toute sa vie.", 
       " se sent comme un poisson dans l'eau.", 
       " a pris son bain.",
       " a tenu 15minutes la tête hors de l'eau.",
       " a battu son record d'apnée.",
       " est heureux d'avoir raté le départ.",
       " s'est retrouvé là par accident.",
       " n'a pas eu de chance.", 
       " chante \"Sous l'océan\".",
       " visite Bikini Bottom.",
       " mange un pâté de crabe.",
       " cherche Dory.",
       " n'aura plus besoin de nouveau lange.",
       " a eu sa dose de sel.",
       " ne verra jamais la France."
    };

    private string[] listPlayer = {
       
    };



    private Text rigole;

    private string finalText;

	void Start () {
        rigole = GetComponent<Text>();

        for( int i = 0; i < 10; i++ )
        {
            finalText += listName[ Random.Range( 0, listName.Length ) ] + listReasons[ Random.Range( 0, listReasons.Length ) ] + "\n" ;
        }
        
        rigole.text = finalText;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
