using UnityEngine;

public class Hacker : MonoBehaviour


{

//Game State
int level;
enum Screen {MainMenu,Password,Win};
Screen currentscreen = Screen.MainMenu;
string Password;

string[] level1Passwords = {"safe", "code", "vault", "cracked"};
string[] level2Passwords = {"compromise", "virginia", "five", "government"};
string[] level3Passwords = {"extraterrestrial", "celestial", "supernatural", "foreign"};

// Bank Vault: safe, code, vault, cracked
	// Area 51: extraterrestrial, celestial, supernatural, foreign
	// Pentagon: compromise, virginia, five, government

    // Start is called before the first frame update
    void Start()
    {
     ShowMainMenu("Sachit");
    }
	void OnUserInput (string input) {
	if(input == "menu") {
	ShowMainMenu ("Sachit"); 
	}else if(currentscreen==Screen.MainMenu){
		SelectLevel(input);
	}
	else if (currentscreen == Screen.Password) {
	CheckPassword(input);
}
	}
	
	private void CheckPassword(string input){
		if(input == Password) {
		DisplayWinScreen();
		} else {
		Terminal.WriteLine("Try again or type menu to go back!");
		}
	}

	void SelectLevel(string inputlevel) {
		if(inputlevel == "1") {
		level = 1;
		StartGame();
		}else if(inputlevel == "2"){
		level = 2;
		StartGame();
		}else{
		level = 3;
		StartGame();
		}
	}
	 
	 private void StartGame()
	 {
	 //khalid
	 currentscreen=Screen.Password;
	 //
	 Terminal.WriteLine("You have chosen level:" + level);
	 switch(level) {
	 	  case 1: 
		  Password = level1Passwords[Random.Range(0, level1Passwords.Length)];
		  break;
		  case 2: 
		  Password = level2Passwords[Random.Range(0, level2Passwords.Length)];
		  break;
		  case 3: 
		  Password = level3Passwords[Random.Range(0, level3Passwords.Length)];
		  break;

		  default:
		  Terminal.WriteLine("You blind?!?! There is no such level!!");
		  break;
	 }
	 Terminal.WriteLine("Enter the password:" + Password.Anagram());
}

	void ShowMainMenu(string name) {
    //khalid
	currentscreen=Screen.MainMenu;
	Terminal.ClearScreen();
	//
	Terminal.WriteLine("Welcome Agent " + name);
	Terminal.WriteLine("Press 1 for Bank Vault Database");
	Terminal.WriteLine("Press 2 for Pentagon");
	Terminal.WriteLine("Press 3 for Area 51");
	Terminal.WriteLine("Enter your selection:");
	
    }

	private void DisplayWinScreen()
	 {

	 currentscreen=Screen.Win;
	 Terminal.ClearScreen();
	 ShowLevelReward();

	 }

	 private void ShowLevelReward()
	 {
	 switch(level) {
	 case 1:
	 Terminal.WriteLine(@" _                 _    
| |               | |   
| |__   __ _ _ __ | | __
| '_ \ / _` | '_ \| |/ /
| |_) | (_| | | | |   < 
|_.__/ \__,_|_| |_|_|\_\") ;
	 break;

	 case 2: 
	 Terminal.WriteLine(@"                _                      
 _ __  ___ _ _| |_ __ _ __ _ ___ _ _  
| '_ \/ -_) ' \  _/ _` / _` / _ \ ' \ 
| .__/\___|_||_\__\__,_\__, \___/_||_|
|_|                    |___/          

  ");
	 break;

	 case 3: 
	 Terminal.WriteLine(@"
   _   ___ ___   _     ___ _ 
  /_\ | _ \ __| /_\   | __/ |
 / _ \|   / _| / _ \  |__ \ |
/_/ \_\_|_\___/_/ \_\ |___/_|
                             
 ");
	 break;
	 default:
	 Terminal.WriteLine("Try Again or type 'menu' to go back!");
	 break;


	 }


	 }





    // Update is called once per frame

    void Update()
    {
        
 }
}
