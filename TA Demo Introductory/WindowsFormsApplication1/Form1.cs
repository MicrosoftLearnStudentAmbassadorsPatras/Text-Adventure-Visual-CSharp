using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            picturebx.Image = Properties.Resources.front_Castle;
            lbl1.Parent = picturebx;
            pnlstats.Parent = picturebx;
            pnlenemy.Parent = picturebx;
        }

        //

        public string name;
        public static int hp = 100, mana = 100, dmg = 5, atk, enemyhp, phasenum;
        public string strenemyhp = (enemyhp).ToString();
        Random rnd = new Random();
        

        //Buttons

        private void cbt1_Click(object sender, EventArgs e)
        {

            if (cbt1.Text == "Light Attack")
            {
                if (enemyhp > 0 && hp > 0)
                {
                    enemyhp -= (dmg + rnd.Next(0,6));
                    hp -= (atk + rnd.Next(0,3));

                    if (hp <= 0)
                    {
                        hp = 0;
                        lbl1.Text = "You are dead";
                    }

                    if (enemyhp <= 0)
                    {
                        enemyhp = 0;
                        lblenemyname.Text += " Defeated";
                        if (hp > 0)
                        {
                            closecombat();
                        }
                    }

                }

                lblenemyhp.Text = (enemyhp).ToString();
                lblhp.Text = (hp).ToString();

                barhp.Value = hp;
                barenemyhp.Value = enemyhp;

            }

            if (cbt1.Text == "Get the battleaxe")
            {
                phase8();
            }
            if (cbt1.Text == "Run back to the lake")
            {
                phase6();
            }
            if (cbt1.Text == "Walk through the corridor")
            {
                phase3();
            }
           

            if (cbt1.Text == "OK")
            {
                name = txtname.Text;
                lblname.Text = name;
                txtname.Visible = false;
                picturebx.Image = Properties.Resources.Castle_Entrance;
                phase1();
            }
            
                    
        }

        private void cbt2_Click(object sender, EventArgs e)
        {
            if (cbt2.Text == "Heavy Attack\n(Drains 25 MANA)")
            {
                if (enemyhp > 0 && mana > 0 && hp > 0)
                {
                    mana -= 25;
                    if(mana <= 0)
                    {
                        mana = 0;
                    }
                    lblmana.Text = (mana).ToString();

                    enemyhp -= (dmg * 2 + rnd.Next(0, 6));

                    hp -= (atk + rnd.Next(0, 3));

                    if (hp <= 0)
                    {
                        hp = 0;
                        lbl1.Text = "You are dead";
                    }

                    if (enemyhp <= 0)
                    {
                        enemyhp = 0;
                        lblenemyname.Text += " Defeated";
                        if (hp > 0)
                        {
                            closecombat();
                        }
                    }
                    
                }

                lblenemyhp.Text = (enemyhp).ToString();
                lblhp.Text = (hp).ToString();

                barhp.Value = hp;
                barmana.Value = mana;
                barenemyhp.Value = enemyhp;

            }

            if (cbt2.Text == "Smash the window")
            {
                phase9();
            }
            if (cbt2.Text == "Traverse through the forest")
            {
                phase7();
            }
            if (cbt2.Text == "Escape the castle")
            {
                phase2();
            }
           
        }

        private void cbtproceed_Click(object sender, EventArgs e)
        {
            cbtproceed.Visible = false;
            phasechoose();
        }

        
        //Combat

        private void startcombat(enemy enem1)
        {
            lblenemyname.Text = enem1.getname();
            enemyhp = enem1.gethp();

            barenemyhp.Maximum = enemyhp;
            barenemyhp.Value = enemyhp;

            pnlenemy.Visible = true;
            cbt1.Text = "Light Attack";
            cbt2.Text = "Heavy Attack\n(Drains 25 MANA)";

            strenemyhp = (enemyhp).ToString();
            lblenemyhp.Text = strenemyhp;

            atk = enem1.getatk();   
        }

        private void closecombat()
        {
            cbtproceed.Visible = true;
            cbt1.Visible = false;
            cbt2.Visible = false;
        }

        private void phasechoose()
        {
            pnlenemy.Visible = false;
            cbt1.Visible = true;
            cbt2.Visible = true;

            switch (phasenum)
            {
                case 2:
                    phase4();
                    break;
                case 3:
                    phase5();
                    break;
                case 6:
                    phase11();
                    break;
                case 7:
                    phase10();
                    break;
                case 8:
                    phase13();
                    break;
                case 9:
                    phase12();
                    break;
            }

        }


        #region Phases

        private void phase1()
        {
            lbl1.Text = "You have awaken from deep sleep. You look around. The place doesn't look familiar. The cold atmosphere makes you shake. Right beside you there is a rusty sword. You hesitate to take it, but conceiving it is your only weapon you pick it up and then you walk slowly to the half open door. You come outside of the room and you realize you are in a big castle. The castle entrance is open. In front of you there is a corridor. The corridor is long and dark, but you fear that if you leave now through the entrance someone may see you in the daylight.";
            cbt1.Text = "Walk through the corridor";
            cbt2.Text = "Escape the castle";
            pnlstats.Visible = true;
            cbt2.Visible = true;
            phasenum = 1;
        }

        private void phase2()
        {
            lbl1.Text = "As you approach the entrance you hear cracking noises coming from above. Suddenly a skeleton falls from the ceiling right front of the castle entrance. You have no other choice than to fight him.";
            picturebx.Image = Properties.Resources.castle_door;
            skeleton skel1 = new skeleton();
            startcombat(skel1);
            phasenum = 2;
        }

        private void phase3()
        {
            lbl1.Text = "You walk into the corridor. It's getting darker and darker. You are surrounded by many locked doors. Suddenly a door opens, behind it there is a skeleton armed with an axe. In order to get out of the dark corridor you must kill the skeleton. You raise your sword and attack.";
            picturebx.Image = Properties.Resources.corridor;
            skeleton skel1 = new skeleton();
            startcombat(skel1);
            phasenum = 3;
        }

        private void phase4()
        {
            lbl1.Text = "You destroyed the skeleton with a lethal blow scattering his bones on the ground. You are now free to pass through the entrance. As you run you notice a lake at your left, it would be nice to go there to wash your hands but you continue running away from the castle as fast as you can. Suddenly the path closes. A big forest is ahead.";
            cbt1.Text = "Run back to the lake";
            cbt2.Text = "Traverse through the forest";
            picturebx.Image = Properties.Resources.Lake_Jungle;
            phasenum = 4;
        }

        private void phase5()
        {
            lbl1.Text = "The skeleton is down in pieces. You walk inside it's cell. There is a battleaxe hanging on the wall. In front of you there is a window. The iron grill on it seems broken. You can smash it with a few sword blows.";
            picturebx.Image = Properties.Resources.castle_window;
            cbt1.Text = "Get the battleaxe";
            cbt2.Text = "Smash the window";
            phasenum = 5;
        }

        private void phase6()
        {
            lbl1.Text = "You run back to the lake. You stay there to wash your hands and drink some water. You feel regenerated now and your Mana has increased. Suddenly a Sea Wyrm shatters the silence of the lake. The smell of your blood is likely to have pulled it to the surface. You must kill it before it eats you alive.";
            picturebx.Image = Properties.Resources.lake;
            mana += 50;
            if (mana > 100)
            {
                barmana.Maximum = mana;
            }
            barmana.Value = mana;
            lblmana.Text = (mana).ToString();

            seawyrm swyrm1=new seawyrm();
            startcombat(swyrm1);
            phasenum = 6;
        }

        private void phase7()
        {
            lbl1.Text = "You cut your way through the forest when you find a glairy new sword nailed on a tree. You pull it out and you throw your rusty sword to the ground. Now you can deal more damage with this new sword. As you continue along you hear something enormous coming to you. Now you see it, it is a troll and it is coming after you. That is your opportunity to test your new sword";
            picturebx.Image = Properties.Resources.jungle;
            dmg += 5;
            troll troll1 = new troll();
            startcombat(troll1);
            phasenum = 7;
        }

        private void phase8()
        {
            lbl1.Text = "You pull the battleaxe from the wall with force making noise. Now you can deal more damage with your new sharp battleaxe. All of a sudden you hear footsteps. You see a knight in full armor coming towards you. The noise must awaken him. He seems aggressive as he keeps walking faster and faster. As he comes in front of you he pulls out his sword and prepares for battle.";
            picturebx.Image = Properties.Resources.knight;
            dmg += 5;
            knight knight1 = new knight();
            startcombat(knight1);
            phasenum = 8;
        }

        private void phase9()
        {
            lbl1.Text = "You smash the window with your sword and you jump to the roof in front of it. Next to you there is a potion. You pick it up, it smells strange. You drink it and you realize that some of your wounds have healed. It is a healing potion, it restores some of your HP. Looking up you notice something flying above you. It comes closer and closer. It is a griffin looking for a pray. You must defend yourself.";
            picturebx.Image = Properties.Resources.castle_roof;
            hp += 10;
            if (hp > 100)
            {
                hp = 100;
            }
            barhp.Value = hp;
            lblhp.Text = (hp).ToString();

            griffin griffin1 = new griffin();
            startcombat(griffin1);
            phasenum = 9;
        }

        private void phase10()
        {
            lbl1.Text = "The troll fell down dead. There is a path behind it. Probably the troll opened it while it was walking. You follow the path. As you walk more and more light appears at the far end of the forest. You finally manage to get out. The forest and the castle are behind you. Congratulations you have successfully escaped!";
            cbt1.Visible = false;
            cbt2.Visible = false;
            phasenum = 10;
        }

        private void phase11()
        {
            lbl1.Text = "The Sea Wyrm is submerging in the depths of the lake. Now you can hear again the silence like before the attack. Nobody is after you. You are now free. Congratulations you have successfully escaped!";
            cbt1.Visible = false;
            cbt2.Visible = false;
            phasenum = 11;
        }

        private void phase12()
        {
            lbl1.Text = "The griffin fell from the roofs of the castle. The castle is surrounded with water. The water is clear and you cannot spot any hostile creature. Without second thought you jump for your life. The water is cold, but you manage to swim across. You touch the land again and you realize you are now free. Congratulations you have successfully escaped!";
            cbt1.Visible = false;
            cbt2.Visible = false;
            phasenum = 12;
        }

        private void phase13()
        {
            lbl1.Text = "The knight is down on his knees. You walk into the dark corridors. All the doors are locked instead of one. You open it. It brings you back from where you started, in the same room with the dead knight, but this time is different. There is no window to escape. You keep going forward and you realize you are walking in circles. The same rooms again and again and again. There is no escape. You are bound to the castle now. You will take the place of the dead knight. You will serve the castle like the knight did for many years, hoping that someday you can be free again.";
            cbt1.Visible = false;
            cbt2.Visible = false;
            phasenum = 13;
        }

        #endregion

    }

    public abstract class enemy
    {
        public int hp,atk;
        public string name;

        public abstract int gethp();
        public abstract int getatk();
        public abstract string getname();
    }

    public class skeleton : enemy
    {
        public override int gethp()
        {
            return this.hp = 90;
        }
        public override int getatk()
        {
            return this.atk = 2;
        }
        public override string getname()
        {
            return this.name = "Skeleton";
        }

    }

    public class troll : enemy
    {
        public override int gethp()
        {
            return this.hp = 110;
        }
        public override int getatk()
        {
            return this.atk = 5;
        }
        public override string getname()
        {
            return this.name = "Troll";
        }

    }

    public class seawyrm : enemy
    {
        public override int gethp()
        {
            return this.hp = 105;
        }
        public override int getatk()
        {
            return this.atk = 5;
        }
        public override string getname()
        {
            return this.name = "Sea Wyrm";
        }
    }

    public class knight : enemy
    {
        public override int gethp()
        {
            return this.hp = 110;
        }
        public override int getatk()
        {
            return this.atk = 5;
        }
        public override string getname()
        {
            return this.name = "Knight";
        }
    }

    public class griffin : enemy
    {
        public override int gethp()
        {
            return this.hp = 105;
        }
        public override int getatk()
        {
            return this.atk = 5;
        }
        public override string getname()
        {
            return this.name = "Griffin";
        }
    }
}
