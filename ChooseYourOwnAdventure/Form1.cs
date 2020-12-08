using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//Justin Andrews
//December 8 2020
//Choose your own adventure
namespace ChooseYourOwnAdventure
{
    public partial class Form1 : Form
    {
        int scene = 1;
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

            outputLabel.Text = "Welcome to the game!\n\nYou are the child of a wonderful mother and farmer living in a cabin just outside of your village. You have never seen trouble in this small village and te king has recognised your farm as the best in his land";
            outputLabel.Text += "\n\nBut everything is about to change... Because suddenly you wake up to a huge explosion! What do you do?";

            blueOutput.Text = "Get up";
            yellowOutput.Text = "Go back to sleep";

            npc1.Parent = backgroundImage;
            npc2.Parent = backgroundImage;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)        //On B press changing scenes
            {
                switch (scene)
                {
                    case 1:
                        scene = 2;
                        break;
                    case 2:
                        scene = 6;
                        break;
                    case 5:
                        scene = 7;
                        break;
                    case 6:
                        scene = 26;
                        break;
                    case 7:
                        int crushed = randGen.Next(1, 5);
                        if (crushed == 1)
                        {
                            scene = 8;
                        }
                        else
                        {
                            scene = 11;
                        }
                        break;
                    case 8:
                        scene = 10;
                        break;
                    case 12:
                        int escape = randGen.Next(1, 3);
                        if (escape == 1)
                        {
                            scene = 16;
                        }
                        else
                        {
                            scene = 15;
                        }
                        break;
                    case 16:
                        scene = 17;
                        break;
                    case 17:
                        scene = 19;
                        break;
                    case 19:
                        scene = 20;
                        break;
                    case 21:
                        scene = 22;
                        break;
                    case 23:
                        scene = 24;
                        break;
                    case 27:
                        scene = 29;
                        break;
                    case 31:
                        scene = 33;
                        break;
                    case 33:
                        scene = 35;
                        break;
                    case 34:
                        scene = 37;
                        break;
                    case 37:
                        scene = 39;
                        break;
                    case 97:
                        scene = 1;
                        break;
                    case 98:
                        scene = 1;
                        break;
                    case 100:
                        scene = 1;
                        break;
                }
            }

            else if (e.KeyCode == Keys.N)       //On N press change scene
            {
                switch (scene)
                {
                    case 1:
                        scene = 3;
                        break;
                    case 2:
                        scene = 5;
                        break;
                    case 5:
                        scene = 17;
                        break;
                    case 6:
                        scene = 28;
                        break;
                    case 7:
                        int ambush = randGen.Next(1, 11);
                        if (ambush < 4)
                        {
                            scene = 8;
                        }
                        else
                        {
                            scene = 12;
                        }
                        break;
                    case 8:
                        scene = 9;
                        break;
                    case 12:
                        scene = 14;
                        break;
                    case 17:
                        scene = 18;
                        break;
                    case 19:
                        scene = 21;
                        break;
                    case 21:
                        scene = 23;
                        break;
                    case 23:
                        scene = 25;
                        break;
                    case 27:
                        scene = 31;
                        break;
                    case 31:
                        scene = 32;
                        break;
                    case 33:
                        scene = 34;
                        break;
                    case 34:
                        scene = 36;
                        break;
                    case 37:
                        scene = 38;
                        break;
                    case 97:
                        scene = 99;
                        break;
                    case 98:
                        scene = 99;
                        break;
                    case 100:
                        scene = 99;
                        break;
                }
            }
            else if (e.KeyCode == Keys.M)       //On M press change scene
            {
                switch (scene)
                {
                    case 2:
                        scene = 4;
                        break;
                    case 6:
                        scene = 27;
                        break;
                    case 12:
                        scene = 13;
                        break;
                    case 27:
                        scene = 30;
                        break;
                    case 97:
                        scene = 100;
                        break;
                    case 100:
                        scene = 100;
                        break;
                    case 98:
                        scene = 100;
                        break;
                }
            }

            SoundPlayer battle = new SoundPlayer(Properties.Resources.battleStart);         //sounds
            SoundPlayer scream = new SoundPlayer(Properties.Resources.scream);
            SoundPlayer killed = new SoundPlayer(Properties.Resources.enemyKilled);
            SoundPlayer forest = new SoundPlayer(Properties.Resources.forestSounds);
            SoundPlayer lose = new SoundPlayer(Properties.Resources.gameOver);
            SoundPlayer victory = new SoundPlayer(Properties.Resources.victory);

            switch (scene)         //Everything that will be in the scenes
            {
                case 1:
                    outputLabel.Text = "Welcome to the game!\n\nYou are the child of a wonderful mother and farmer living in a cabin just outside of your village. You have never seen trouble in this small village and the king has recognised your farm as the best in his land";
                    outputLabel.Text += "\n\nBut everything is about to change... Because suddenly you wake up to a huge explosion! What do you do?";

                    backgroundImage.BackgroundImage = Properties.Resources.Cabin;
                    blueOutput.Text = "Get up";
                    yellowOutput.Text = "Go back to sleep";
                    redOutput.Text = "";

                    npc1.Visible = false;
                    npc2.Visible = false;
                    blueLabel.Visible = true;
                    yellowLabel.Visible = true;
                    redLabel.Visible = true;
                    redButton.Visible = true;
                    break;
                case 2:
                    outputLabel.Text = "You get up and as you exit your room, you find two slimes attacking your mom!\n\nWhat do you do?";
                    battle.Play();

                    npc1.Visible = true;
                    npc2.Visible = true;
                    npc1.BackgroundImage = Properties.Resources.slime;
                    npc2.BackgroundImage = Properties.Resources.slime;

                    blueOutput.Text = "Attack";
                    yellowOutput.Text = "Run";
                    redOutput.Text = "Nothing";
                    redButton.Visible = true;

                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;
                    break;
                case 3:
                    outputLabel.Text = "You died peacefully in your sleep.";
                    lose.Play();
                    redOutput.Text = "";
                    redButton.Visible = false;
                    scene = 97;

                    blueLabel.Visible = false;
                    yellowLabel.Visible = false;
                    redLabel.Visible = false;

                    goto Lose;
                case 4:
                    outputLabel.Text = "You accepted your death gracefully.";
                    lose.Play();
                    redOutput.Text = "";
                    redButton.Visible = false;
                    scene = 97;

                    goto Lose;
                case 5:
                    outputLabel.Text = "You ran like a coward and left your caring mother to die, but you lived.\n\nWhere do you run to?";
                    blueOutput.Text = "To the castle";
                    yellowOutput.Text = "To the forest";
                    redOutput.Text = "";
                    redButton.Visible = false;

                    npc1.Visible = false;
                    npc2.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "You engage the slimes in a battle.\n\nHow do you start?";
                    blueOutput.Text = "Magic";
                    yellowOutput.Text = "Defend";
                    redOutput.Text = "Attack";
                    redButton.Visible = true;
                    break;
                case 7:
                    outputLabel.Text = "The town is in ruin.\n\nWhich path to the castle do you take?";
                    blueOutput.Text = "Through the main streets";
                    yellowOutput.Text = "Through the side streets";
                    redOutput.Text = "";
                    redButton.Visible = false;

                    backgroundImage.BackgroundImage = Properties.Resources.Town;
                    break;
                case 8:
                    outputLabel.Text = "You made it safely to the outside of the castle.\n\nHow do you approach?";

                    blueOutput.Text = "Slowly with hands raised";
                    yellowOutput.Text = "Running for your life";

                    backgroundImage.BackgroundImage = Properties.Resources.Castle;
                    break;
                case 9:
                    outputLabel.Text = "You were seen as a threat and killed on sight.";
                    lose.Play();
                    npc1.Visible = true;
                    npc1.BackgroundImage = Properties.Resources.knight;
                    scene = 97;
                    redButton.Visible = false;

                    goto Lose;
                case 10:
                    outputLabel.Text = "As you approach the guard you inform him of the chaos happening in the village. He was visibly shocked at the news and quickly thanked you and ran to gather other knights to fight off the monsters. The guards are victorious and you are recognised as a hero.";
                    victory.Play();
                    npc1.Visible = true;
                    npc1.BackgroundImage = Properties.Resources.knight;
                    redButton.Visible = false;

                    scene = 98;
                    goto Win;
                case 11:
                    outputLabel.Text = "You were crushed by a building with no chance of survival.";
                    lose.Play();
                    backgroundImage.BackgroundImage = Properties.Resources.mainStreets;
                    scene = 97;
                    redButton.Visible = false;

                    goto Lose;
                case 12:
                    outputLabel.Text = "You were ambushed by two werewolves on your way to the castle.\n\nWhat do you do?";
                    battle.Play();
                    blueOutput.Text = "Run";
                    yellowOutput.Text = "Defend";
                    redOutput.Text = "Attack";
                    redButton.Visible = true;

                    backgroundImage.BackgroundImage = Properties.Resources.sideStreets;
                    npc1.Visible = true;
                    npc2.Visible = true;

                    npc1.BackgroundImage = Properties.Resources.werewolf;
                    npc2.BackgroundImage = Properties.Resources.werewolf;
                    break;
                case 13:
                    outputLabel.Text = "You got destroyed. You didn't even stand a chance.";
                    lose.Play();
                    scene = 97;
                    redButton.Visible = false;

                    goto Lose;
                case 14:
                    outputLabel.Text = "Did you really just defend against razor sharp claws? You're dead";
                    lose.Play();
                    scene = 97;
                    redButton.Visible = false;

                    goto Lose;
                case 15:
                    outputLabel.Text = "The were wolves caught you and had themselves a feast.";
                    lose.Play();
                    scene = 97;
                    yellowButton.Visible = true;
                    redButton.Visible = false;

                    goto Lose;
                case 16:
                    outputLabel.Text = "The werewolves lost interest in you and you got away!";
                    blueOutput.Text = "Continue";
                    yellowOutput.Text = "";
                    redOutput.Text = "";
                    redButton.Visible = false;
                    yellowButton.Visible = false;

                    npc1.Visible = false;
                    npc2.Visible = false;
                    break;
                case 17:
                    outputLabel.Text = "You escaped to the forest away from all the fighting. You see a lake in the distance but it's a bit closer to the village\n\nWhere to now?";
                    forest.Play();
                    blueOutput.Text = "Continue Straight";
                    yellowOutput.Text = "Go to the lake";
                    yellowButton.Visible = true;

                    backgroundImage.BackgroundImage = Properties.Resources.forest;
                    break;
                case 18:
                    outputLabel.Text = "You were ambushed by creatures in the lake when you got close. You died";
                    lose.Play();
                    scene = 97;
                    backgroundImage.BackgroundImage = Properties.Resources.lake;
                    npc1.Visible = true;
                    npc2.Visible = true;
                    redButton.Visible = false;

                    npc1.BackgroundImage = Properties.Resources.waterMonster;
                    npc2.BackgroundImage = Properties.Resources.waterMonster;

                    goto Lose;
                case 19:
                    outputLabel.Text = "You continue forward for what feels like days until you come across a hut.\n\nHow do you approach?";
                    blueOutput.Text = "Run in";
                    yellowOutput.Text = "Sneak";
                    backgroundImage.BackgroundImage = Properties.Resources.Hut;
                    break;
                case 20:
                    outputLabel.Text = "You run towards the shack at full speed, trip, and snap your neck. Great Job.";
                    lose.Play();
                    scene = 97;
                    redButton.Visible = false;

                    goto Lose;
                case 21:
                    outputLabel.Text = "You take it slow and sneak in a window.\n\nYou're starving, do you take any food?";
                    backgroundImage.BackgroundImage = Properties.Resources.insideHut;
                    blueOutput.Text = "Yes";
                    yellowOutput.Text = "No";
                    break;
                case 22:
                    outputLabel.Text = "You suddenly get stabbed through the chest. The owner of the shack wasn't too happy to see you stealing.";
                    lose.Play();
                    scene = 97;
                    redButton.Visible = false;

                    goto Lose;
                case 23:
                    outputLabel.Text = "Suddenly, a witch appears. She seems pleased with your choice.\n\nDo you attack?";
                    blueOutput.Text = "Yes";
                    yellowOutput.Text = "No";

                    npc1.Visible = true;
                    npc1.BackgroundImage = Properties.Resources.witch;
                    break;
                case 24:
                    outputLabel.Text = "You attack and get killed instantly. It was pathetic.";
                    lose.Play();
                    scene = 97;
                    redButton.Visible = false;

                    goto Lose;
                case 25:
                    outputLabel.Text = "You have a wonderful conversation with the witch. It finalizes with you becoming her apprentice. Everyone in the village died but you're having fun.";
                    scene = 98;
                    redButton.Visible = false;

                    goto Win;
                case 26:
                    outputLabel.Text = "You chanted a spell and realized too late you don't know how to use magic.";
                    lose.Play();
                    redOutput.Text = "";
                    redButton.Visible = false;
                    scene = 97;

                    goto Lose;
                case 27:
                    outputLabel.Text = "You attack one slime with a chair killing it. The other lunges at you.\n\nDodge!";
                    killed.Play();
                    blueOutput.Text = "Left";
                    yellowOutput.Text = "Right";
                    redOutput.Text = "Duck";
                    redButton.Visible = true;

                    npc2.Visible = false;
                    break;
                case 28:
                    outputLabel.Text = "The slimes flanked and killed you.";
                    lose.Play();
                    redOutput.Text = "";
                    redButton.Visible = false;
                    scene = 97;

                    goto Lose;
                case 29:
                    outputLabel.Text = "You jump into a wall knocking yourself out. The slime then kills you.";
                    lose.Play();
                    scene = 97;
                    redOutput.Text = "";
                    redButton.Visible = false;

                    goto Lose;
                case 30:
                    outputLabel.Text = "You duck, but the slime was going for your legs so it hits you in the chest instead. You are killed.";
                    lose.Play();
                    scene = 97;
                    redOutput.Text = "";
                    redButton.Visible = false;

                    goto Lose;
                case 31:
                    outputLabel.Text = "You successfully dodge the slime's attack and counter it before it had a chance to react.\n\nWhat now?";
                    killed.Play();
                    npc1.Visible = false;

                    blueOutput.Text = "Help out";
                    yellowOutput.Text = "Stay at home";
                    redOutput.Text = "";
                    redButton.Visible = false;
                    break;
                case 32:
                    outputLabel.Text = "Your house collapsed and you died. Don't be lazy";
                    lose.Play();
                    scene = 97;
                    redButton.Visible = false;

                    goto Lose;
                case 33:
                    outputLabel.Text = "You go around the village with your limited skills helping citizens. Suddenly, a horde of different monster flood the streets.\n\nWhat do you do?";
                    scream.Play();
                    blueOutput.Text = "Keep Helping";
                    yellowOutput.Text = "Follow the horde";

                    backgroundImage.BackgroundImage = Properties.Resources.mainStreets;
                    npc1.Visible = true;
                    npc2.Visible = true;
                    npc1.BackgroundImage = Properties.Resources.werewolf;
                    npc2.BackgroundImage = Properties.Resources.slime;
                    break;
                case 34:
                    outputLabel.Text = "You follow the horde all the way to the castle. You then listen in on a conversation hearing the king has been exploiting the monsters and has been using them as slaves.\n\nWhich side do you take?";
                    blueOutput.Text = "Monsters";
                    yellowOutput.Text = "Humans";

                    backgroundImage.BackgroundImage = Properties.Resources.Castle;
                    break;
                case 35:
                    outputLabel.Text = "You continue helping people in need. While helping get someone out of a building, you are attacked and killed by an orc. You died a hero.";
                    lose.Play();
                    npc2.BackgroundImage = Properties.Resources.orc;
                    npc1.Visible = false;
                    scene = 97;
                    redButton.Visible = false;

                    goto Lose;
                case 36:
                    outputLabel.Text = "You stay loyal to your birth and help the soldiers in the castle get to the fight and save the king. You are the hero of the humans.";
                    victory.Play();
                    backgroundImage.BackgroundImage = Properties.Resources.ThroneRoom;
                    npc1.BackgroundImage = Properties.Resources.knight;
                    npc2.BackgroundImage = Properties.Resources.royalKnight;
                    scene = 98;
                    redButton.Visible = false;

                    goto Win;
                case 37:
                    outputLabel.Text = "You side with the oppressed monsters and meet with their leader to decide with them how to approach the castle and king.\n\nWhat is your approach?";
                    blueOutput.Text = "Peaceful";
                    yellowOutput.Text = "Violent";

                    npc1.Visible = false;
                    npc2.BackgroundImage = Properties.Resources.orc;
                    break;
                case 38:
                    outputLabel.Text = "You decide to take the violent approach, with the monsters you charge the castle killing everyone in sight including the king. The monsters rule with an iron fist and you are one of the highest ranked nobles";
                    victory.Play();
                    scene = 98;
                    redButton.Visible = false;

                    backgroundImage.BackgroundImage = Properties.Resources.ThroneRoom;

                    goto Win;
                case 39:
                    outputLabel.Text = "With the monsters at your side, you take the castle only with the force required. After taking the throne room from the king you tell the humans of the monster oppression and they, like you, side with the monsters. The monsters and humans rule in peace and you are part of the council created.";
                    victory.Play();
                    scene = 98;

                    backgroundImage.BackgroundImage = Properties.Resources.ThroneRoom;
                    npc1.Visible = true;
                    npc1.BackgroundImage = Properties.Resources.royalKnight;
                    redButton.Visible = false;

                    goto Win;
                case 97:
                    Lose:
                    outputLabel.Text += "\n\nYou Lose, Play Again?";

                    blueOutput.Text = "Yes";
                    yellowOutput.Text = "No";
                    break;
                case 98:
                    Win:
                    outputLabel.Text += "\n\nYou Win! Play Again?";

                    blueOutput.Text = "Yes";
                    yellowOutput.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thanks for Playing!";
                    break;
                case 100:
                    outputLabel.Text = "That wasn't an option";
                    goto Lose;
                    

            }
        }
    }
}
