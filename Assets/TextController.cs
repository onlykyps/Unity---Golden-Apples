using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour 
{
	
	public Text text;
	private enum States {Throne_Room, Garden, Garden_Spikes, Library, Armory, Examine_Tree, Examine_Ground, Examine_Ground_Spikes, Fall_Asleep, Sword, Bow_and_Arrows, 
		Spikes, Armory_Spikes, Plant_Spikes, Stand_Guard_Spikes, Thief_Arrives, Climb_Tree, Throw_Spikes, Armory_eqpd_Spikes, View_Sword_holding_Spikes, Armory_eqpd_Spikes_Sword, Garden_eqpd_Spikes_Sword,
		Examine_Ground_Sword, Examine_Tree_Sword, Plant_Spikes_Sword, Stand_Guard_Spikes_Sword, Thief_Arrives_Spikes_Sword, Climb_Tree_Sword, Fall_Asleep_Spikes_Sword,
		View_Bow_and_Arrows_holding_Spikes, Armory_eqpd_Spikes_Bow_and_Arrows, Garden_eqpd_Spikes_Bow_and_Arrows, Examine_Tree_Spikes_Bow_and_Arrows, Examine_Ground_Spikes_Bow_and_Arrows,
		Plant_Spikes_Bow_and_Arrows, Fall_Asleep_Spikes_Bow_and_Arrows, Stand_Guard_Spikes_Bow_and_Arrows, Thief_Arrives_Spikes_Bow_and_Arrows, Climb_Tree_Spikes_Bow_and_Arrows, Shoot_Arrows, 
		Small_Victory_Spikes_Bow_and_Arrows, Small_Victory_Spikes_Bow_and_Arrows_Return, Fail_Spikes_Bow_and_Arrows, View_Sword_holding_Spikes_Bow_and_Arrows, Armory_eqpd_Spikes_Bow_and_Arrows_Sword, 
		Garden_eqpd_Spikes_Bow_and_Arrows_Sword, Examine_Tree_All, Examine_Ground_All, Plant_Spikes_All, Stand_Guard_All, Fall_Asleep_All, Thief_Arrives_All, Climb_Tree_All, Shoot_Arrows_All, 
		Small_Victory_All, Small_Victory_All_Return, Fail_All, Stand_Guard_No_Plan_All, View_Bow_and_Arrows_holding_Spikes_Sword, Armory_Sword, View_Bow_and_Arrows_holding_Sword,
		Armory_eqpd_Sword_Bow_and_Arrows, Garden_eqpd_Sword_Bow_and_Arrows, Garden_Sword, Examine_Tree_eqpd_Sword, Examine_Ground_eqpd_Sword, Stand_Guard_Sword, View_Spikes_holding_Sword, 
		Examine_Tree_Sword_Bow_and_Arrows, Examine_Ground_Sword_Bow_and_Arrows, Stand_Guard_Sword_Bow_and_Arrows, Plant_Arrows_eqpd_Sword, Stand_Guard_Arrows_Plant, Fall_Asleep_Sword_Arrow, 
		Thief_Arrives_Sword_Bow_and_Arrows, Climb_Tree_Sword_Bow_and_Arrows, Shoot_Arrows_Sword_Bow_and_Arrows, Shoot_Planted_Arrows_Sword_Bow_and_Arrows, Armory_eqpd_Bow_and_Arrows, Garden_Bow_and_Arrows,
		Examine_Tree_Bow_and_Arrows, Examine_Ground_Bow_and_Arrows, Stand_Guard_Bow_and_Arrows, Plant_Arrows, Stand_Guard_Arrows_Plant_Bow_and_Arrows, Fall_Asleep_Bow_and_Arrows, Thief_Arrives_Bow_and_Arrows,
		Shoot_Arrows_Bow_and_Arrows, Shoot_Planted_Arrows_Bow_and_Arrows, View_Sword_holding_Bow_and_Arrows, View_Spikes_holding_Bow_and_Arrows, Exposition};
	
	private States myState;
	
	// Use this for initialization
	void Start () 
	{
			myState=States.Exposition;
	}
	
	// Update is called once per frame
	void Update () 
	{
			print (myState);
			
			if (myState== States.Throne_Room) 
			{
				state_Throne_Room();
			} 
			else if (myState==States.Garden)
			{
				state_garden();
			}
			
			else if (myState==States.Library)
			{
				state_Library();
			} 
			else if (myState==States.Armory)
			{
				state_Armory();			
			} 
			else if (myState==States.Examine_Tree) 
			{
				state_Examine_Tree();
			} 
			else if (myState==States.Examine_Ground)
			{
				state_Examine_Ground();
			}
			else if (myState==States.Fall_Asleep)
			{
				state_Fall_Sleep();
			}
			else if (myState==States.Sword) 
			{
				state_Sword();
			}
			else if (myState==States.Bow_and_Arrows)
			{
				state_Bow_and_Arrow();
			}
			else if (myState==States.Spikes)
			{
				state_Spikes();
			}
			else if (myState==States.Armory_Spikes) 
			{
				state_Armory_Spikes();
			}
			else if (myState==States.Garden_Spikes) 
			{
				state_Garden_Spikes();
			}
			else if (myState==States.Examine_Ground_Spikes)
			{
				state_Examine_Ground_Spikes();
			}
			else if (myState==States.Plant_Spikes) 
			{
				state_Plant_Spikes();
			}
			else if (myState==States.Stand_Guard_Spikes)
			{
				state_Stand_Guard_Spikes();
			}
			else if (myState==States.Thief_Arrives)
			{
				state_Thief_Arrives();
			}
			else if (myState==States.Climb_Tree)
			{
				state_Climb_Tree();
			}
			else if (myState==States.Throw_Spikes)
			{
				state_Throw_Spikes();
			}
			else if (myState==States.Armory_eqpd_Spikes)
			{
				state_Armory_eqpd_Spikes();
			}
			else if (myState==States.View_Sword_holding_Spikes)
			{
				state_View_Sword_holding_Spikes();
			}
			else if (myState==States.Armory_eqpd_Spikes_Sword)
			{
				state_Armory_eqpd_Spikes_Sword();
			}
			else if (myState==States.Garden_eqpd_Spikes_Sword) 
			{
				state_Garden_eqpd_Spikes_Sword();
			}
			else if (myState==States.Examine_Ground_Sword)
			{
				state_Examine_Ground_Sword();
			}
			else if (myState==States.Examine_Tree_Sword) 
			{
				state_Examine_Tree_Sword();
			}
			else if (myState==States.Plant_Spikes_Sword)
			{
				state_Plant_Spikes_Sword();
			}
			else if (myState==States.Stand_Guard_Spikes_Sword)
			{
				state_Stand_Guard_Spikes_Sword();
			}
			else if (myState==States.Thief_Arrives_Spikes_Sword)
			{
				state_Thief_Arrives_Spikes_Sword();
			}
			else if (myState==States.Climb_Tree_Sword)
			{
				state_Climb_Tree_Sword();
			}
			else if (myState==States.Fall_Asleep_Spikes_Sword)
			{
				state_Fall_Asleep_Spikes_Sword();
			}
			else if (myState==States.View_Bow_and_Arrows_holding_Spikes)
			{
				state_View_Bow_and_Arrows_holding_Spikes();
			}
			else if (myState==States.Armory_eqpd_Spikes_Bow_and_Arrows)
			{
				state_Armory_eqpd_Spikes_Bow_and_Arrows();	
			}
			else if (myState==States.Garden_eqpd_Spikes_Bow_and_Arrows)
			{
				state_Garden_eqpd_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Examine_Tree_Spikes_Bow_and_Arrows)
			{
				state_Examine_Tree_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Examine_Ground_Spikes_Bow_and_Arrows)
			{
				state_Examine_Ground_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Plant_Spikes_Bow_and_Arrows)
			{
				state_Plant_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Fall_Asleep_Spikes_Bow_and_Arrows)
			{
				state_Fall_Asleep_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Stand_Guard_Spikes_Bow_and_Arrows)
			{
				state_Stand_Guard_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Thief_Arrives_Spikes_Bow_and_Arrows)
			{
				state_Thief_Arrives_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Climb_Tree_Spikes_Bow_and_Arrows)
			{
				state_Climb_Tree_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Shoot_Arrows)
			{
				state_Shoot_Arrows();
			}
			else if (myState==States.Small_Victory_Spikes_Bow_and_Arrows)
			{
				state_Small_Victory_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Small_Victory_Spikes_Bow_and_Arrows_Return)
			{
				state_Small_Victory_Spikes_Bow_and_Arrows_Return();
			}
			else if (myState==States.Fail_Spikes_Bow_and_Arrows)
			{
				state_Fail_Spikes_Bow_and_Arrows();	
			}
			else if (myState==States.View_Sword_holding_Spikes_Bow_and_Arrows)
			{
				state_View_Sword_holding_Spikes_Bow_and_Arrows();
			}
			else if (myState==States.Armory_eqpd_Spikes_Bow_and_Arrows_Sword)
			{
				state_Armory_eqpd_Spikes_Bow_and_Arrows_Sword();
			}
			else if (myState==States.Garden_eqpd_Spikes_Bow_and_Arrows_Sword)
			{
				state_Garden_eqpd_Spikes_Bow_and_Arrows_Sword();
			}
			else if (myState==States.Examine_Tree_All)
			{
				state_Examine_Tree_All ();		
			}
			else if (myState==States.Examine_Ground_All)
			{
				state_Examine_Ground_All ();
			}
			else if (myState==States.Plant_Spikes_All)
			{
				state_Plant_Spikes_All ();
			}
			else if (myState==States.Stand_Guard_All)
			{
				state_Stand_Guard_All ();
			}
			else if (myState==States.Fall_Asleep_All)
			{
				state_Fall_Asleep_All ();
			}
			else if (myState==States.Thief_Arrives_All)
			{
				state_Thief_Arrives_All ();
			}
			else if (myState==States.Climb_Tree_All)
			{
				state_Climb_Tree_All ();
			}
			else if (myState==States.Shoot_Arrows_All)
			{
				state_Shoot_Arrows_All ();
			}
			else if (myState==States.Small_Victory_All)
			{
				state_Small_Victory_All ();
			}
			else if (myState==States.Small_Victory_All_Return)
			{
				state_Small_Victory_All_Return ();
			}
			else if (myState==States.Fail_All)
			{
				state_Fail_All ();	
			}
			else if (myState==States.Stand_Guard_No_Plan_All)
			{
				state_Stand_Guard_No_Plan_All ();
			}
			else if (myState==States.View_Bow_and_Arrows_holding_Spikes_Sword)
			{
				state_View_Bow_and_Arrows_holding_Spikes_Sword ();
			}
			else if (myState==States.Armory_Sword)
			{
				state_Armory_Sword ();
			}
			else if (myState==States.View_Bow_and_Arrows_holding_Sword)
			{
				state_View_Bow_and_Arrows_holding_Sword ();
			}
			else if (myState==States.Armory_eqpd_Sword_Bow_and_Arrows)
			{
				state_Armory_eqpd_Sword_Bow_and_Arrows ();
			}
			else if (myState==States.Garden_eqpd_Sword_Bow_and_Arrows)
			{
				state_Garden_eqpd_Sword_Bow_and_Arrows();
			}
			else if (myState==States.Garden_Sword)
			{
				state_Garden_Sword();
			}
			else if (myState==States.Examine_Tree_eqpd_Sword)
			{
				state_Examine_Tree_eqpd_Sword();
			}
			else if (myState==States.Examine_Ground_eqpd_Sword)
			{
				state_Examine_Ground_eqpd_Sword();
			}
			else if (myState==States.Stand_Guard_Sword)
			{
				state_Stand_Guard_Sword();
			}
			else if (myState==States.View_Spikes_holding_Sword)
			{
				state_View_Spikes_holding_Sword();
			}
			else if (myState==States.Examine_Tree_Sword_Bow_and_Arrows)
			{
				state_Examine_Tree_Sword_Bow_and_Arrows();
			}
			else if (myState==States.Examine_Ground_Sword_Bow_and_Arrows)
			{
				state_Examine_Ground_Sword_Bow_and_Arrows();
			}
			else if (myState==States.Stand_Guard_Sword_Bow_and_Arrows)
			{
				state_Stand_Guard_Sword_Bow_and_Arrows ();
			}
			else if (myState==States.Plant_Arrows_eqpd_Sword)
			{
				state_Plant_Arrows_eqpd_Sword ();
			}
			else if (myState==States.Stand_Guard_Arrows_Plant)
			{
				state_Stand_Guard_Arrows_Plant ();
			}
			else if (myState==States.Fall_Asleep_Sword_Arrow)
			{
				state_Fall_Asleep_Sword_Arrow();
			}
			else if (myState==States.Thief_Arrives_Sword_Bow_and_Arrows)
			{
				state_Thief_Arrives_Sword_Bow_and_Arrows();
			}
			else if (myState==States.Climb_Tree_Sword_Bow_and_Arrows)
			{
				state_Climb_Tree_Sword_Bow_and_Arrows();
			}
			else if (myState==States.Shoot_Arrows_Sword_Bow_and_Arrows)
			{
				state_Shoot_Arrows_Sword_Bow_and_Arrows();
			}
			else if (myState==States.Shoot_Planted_Arrows_Sword_Bow_and_Arrows)
			{
				state_Shoot_Planted_Arrows_Sword_Bow_and_Arrows();
			}
			else if (myState==States.Armory_eqpd_Bow_and_Arrows)
			{
				state_Armory_eqpd_Bow_and_Arrows();
			}
			else if (myState==States.Garden_Bow_and_Arrows)
			{
				state_Garden_Bow_and_Arrows ();
			}
			else if (myState==States.Examine_Tree_Bow_and_Arrows)
			{
				state_Examine_Tree_Bow_and_Arrows ();
			}
			else if (myState==States.Examine_Ground_Bow_and_Arrows)
			{
				state_Examine_Ground_Bow_and_Arrows ();
			}
			else if (myState==States.Stand_Guard_Bow_and_Arrows)
			{
				state_Stand_Guard_Bow_and_Arrows ();	
			}
			else if (myState==States.Plant_Arrows)
			{
				state_Plant_Arrows ();	
			}
			else if (myState==States.Stand_Guard_Arrows_Plant_Bow_and_Arrows)
			{
				state_Stand_Guard_Arrows_Plant_Bow_and_Arrows();
			}
			else if (myState==States.Fall_Asleep_Bow_and_Arrows)
			{
				state_Fall_Asleep_Bow_and_Arrows ();
			}
			else if (myState==States.Thief_Arrives_Bow_and_Arrows)
			{
				state_Thief_Arrives_Bow_and_Arrows ();
			}
			else if (myState==States.Shoot_Arrows_Bow_and_Arrows)
			{
				state_Shoot_Arrows_Bow_and_Arrows ();
			}
			else if (myState==States.Shoot_Planted_Arrows_Bow_and_Arrows)
			{
				state_Shoot_Planted_Arrows_Bow_and_Arrows ();
			}
			else if (myState==States.View_Sword_holding_Bow_and_Arrows)
			{
				state_View_Sword_holding_Bow_and_Arrows ();
			}
			else if (myState==States.View_Spikes_holding_Bow_and_Arrows)
			{
				state_View_Spikes_holding_Bow_and_Arrows ();	
			}
			else if (myState==States.Exposition)
			{
				state_Exposition ();
			}
	}
	
	void state_Exposition ()
	{
		text.text="Once upon a time, there was an unique apple tree, its fruits turned Gold. The tree belonged to a great king, your father, and it grew in his garden.\n\n"
				+ "However, for the past two years, a Thief apsconded with the golden apples. Your two elder brothers have failed in catching the Thief. Is this automne your chance to prove yourself? \n\n" +
				 "Press I to Accept the challenge! ";
				 
				 if (Input.GetKeyDown(KeyCode.I))
				 {
				 myState=States.Throne_Room;
				 }
	}
	
	void state_View_Spikes_holding_Bow_and_Arrows ()
	{
		text.text="The Spikes would be useful for mele combat and to poke your eye out if you're careless." 
			+ "Could you use the spikes instead of arrows? \n\n"
				+"Press P to Pick up the Spikes or A to look away";
		
		if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Armory_eqpd_Spikes_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.A))
		{
			myState=States.Armory_eqpd_Bow_and_Arrows;
		}
	}
	
	void state_View_Sword_holding_Bow_and_Arrows ()
	{
		text.text="It is your father's sword! The mighty sword that vanquished all the balaurs!!! \n\n" + 
			"Press A to look away or P to Pick-up the Sword";
		
		if (Input.GetKeyDown(KeyCode.A)) 
		{
			myState=States.Armory_eqpd_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Armory_eqpd_Sword_Bow_and_Arrows;
		}
	}
	
	void state_Shoot_Planted_Arrows_Bow_and_Arrows ()
	{
		text.text="You pull an arrow from the ground and shoot! The arrow flies chaotically to the side." 
			+ "Its fletching and nock were damaged from being shoved into the ground. The other two arrows suffer the same fate."
				+ "The thief gets away. Press R to return to the Throne Room";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Shoot_Arrows_Bow_and_Arrows ()
	{
		text.text="You shoot the three arrows from your quiver and you miss three times! You remember the arrows you used to stay awake.\n\n"
			+ "Press P to Pull the planted arrows from the ground or R to give up...";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Shoot_Planted_Arrows_Bow_and_Arrows;
		}
	}
	
	void state_Thief_Arrives_Bow_and_Arrows ()
	{
		text.text="You hear a rustle in the branches. You look up and, in the moonlight, you see the glistening Golden Apples disappearing as a flying shadowy figure swipes them. \n\n"
			+ "Press S to shoot Arrows at the Thief!";
		
		
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Shoot_Arrows_Bow_and_Arrows; 
		}
	}
	
	void state_Fall_Asleep_Bow_and_Arrows ()
	{
		text.text="You move an arrow to the side and eventually fall asleep. The next morning you discover the apples have all gone.\n\n"
			+"Press R to try again";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
		
	void state_Stand_Guard_Arrows_Plant_Bow_and_Arrows()
	{
		text.text="The sun sets and you find yourself well into the late hours of the night. You often fall to the side from exhaustion, but the arrows prick you back awake. The Thief has yet to arrive. \n\n"
			+ "Press L to give up or P to Push forward";
		
		if (Input.GetKeyDown(KeyCode.L))
		{
			myState=States.Fall_Asleep_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Thief_Arrives_Bow_and_Arrows; 
		}
	}
	
	void state_Plant_Arrows ()
	{
		text.text="You plant three arrows, at an angle and point up. You have three arrows left in your quiver.\n\n"
				+ "Press P to pick up your arrows or S to Stand guard inbetween the arrows";
				
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Stand_Guard_Arrows_Plant_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Garden_Bow_and_Arrows;
		}
				
	}
	
	void state_Stand_Guard_Bow_and_Arrows ()
	{
		text.text="You begin your watch! You also fall asleep half way through the night. The next morning you discover the apples are gone.\n\n"
				+ "Press R to Return to the Throne Room";
				
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Examine_Ground_Bow_and_Arrows ()
	{
		text.text="You press the ground with your foot. It is soft.\n\n"
			+ "Press A to look Away or press P to Plant arrows";
		
		if (Input.GetKeyDown(KeyCode.A))
		{
			myState=States.Garden_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Plant_Arrows;
		}
	}
	
	void state_Examine_Tree_Bow_and_Arrows ()
	{
		text.text="You look at the Golden Apples Tree.\n\n"
			+ "Press A to look Away";
		if (Input.GetKeyDown(KeyCode.A))
		{
			myState=States.Garden_Bow_and_Arrows;
		}
	}
	
	void state_Garden_Bow_and_Arrows ()
	{
		text.text ="You are in the garden equipped with a bow and arrows.\n\n"
				 + "Press T to examine the Tree, G to examine the Ground or B to Begin your watch";
		
		if (Input.GetKeyDown(KeyCode.T))
		{
			myState=States.Examine_Tree_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.G))
		{
			myState=States.Examine_Ground_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.W))
		{
			myState=States.Stand_Guard_Bow_and_Arrows;
		}
				 
	}
	
	void state_Armory_eqpd_Bow_and_Arrows()
	{
		text.text="You are now equipped with a bow and six arrows in a quiver.\n\n"
				+ "Press L to go to the Garden, S to examine the Sword or P to examine the Spikes";
				
				if (Input.GetKeyDown(KeyCode.L))
				{
					myState=States.Garden_Bow_and_Arrows;
				}
				else if (Input.GetKeyDown(KeyCode.S))
				{
					myState=States.View_Sword_holding_Bow_and_Arrows;
				}
				else if (Input.GetKeyDown(KeyCode.P))
				{
					myState=States.View_Spikes_holding_Bow_and_Arrows;
				}
	}
	
	void state_Shoot_Planted_Arrows_Sword_Bow_and_Arrows()
	{
		text.text="You pull an arrow from the ground and shoot! The arrow flies chaotically to the side." 
				+ "Its fletching and nock were damaged from being shoved into the ground. The other two arrows suffer the same fate."
				+ "The thief gets away. Press R to return to the Throne Room";
				
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Shoot_Arrows_Sword_Bow_and_Arrows()
	{
		text.text="You shoot the three arrows from your quiver and you miss three times! You remember the arrows you used to stay awake.\n\n"
				+ "Press P to Pull the planted arrows from the ground or R to give up...";
				
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Shoot_Planted_Arrows_Sword_Bow_and_Arrows;
		}
	}
	
	void state_Climb_Tree_Sword_Bow_and_Arrows()
	{
		text.text="You draw your father's mighty Sword and climb the tree, but between its branches you completly loose sight of the Thief and it gets aways. \n\n"
			+ "Press R to return to your soon to be very disappointed Father";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Thief_Arrives_Sword_Bow_and_Arrows()
	{
		text.text="You hear a rustle in the branches. You look up and, in the moonlight, you see the glistening Golden Apples disappearing as a flying shadowy figure swipes them. \n\n"
			+ "Press C to climb up the tree or S to shoot Arrows at the Thief!";
		
		if (Input.GetKeyDown(KeyCode.C))
		{
			myState=States.Climb_Tree_Sword_Bow_and_Arrows; 
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Shoot_Arrows_Sword_Bow_and_Arrows; 
		}
	}
	
	void state_Fall_Asleep_Sword_Arrow ()
	{
		text.text="You move an arrow to the side and eventually fall asleep. The next morning you discover the apples have all gone.\n\n"
			+"Press R to try again";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Stand_Guard_Arrows_Plant ()
	{
		text.text="The sun sets and you find yourself well into the late hours of the night. You often fall to the side from exhaustion, but the arrows prick you back awake. The Thief has yet to arrive. \n\n"
			+ "Press L to give up or P to Push forward";
		
		if (Input.GetKeyDown(KeyCode.L))
		{
			myState=States.Fall_Asleep_Sword_Arrow;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Thief_Arrives_Sword_Bow_and_Arrows; 
		}
	}
	
	void state_Plant_Arrows_eqpd_Sword ()
	{
		text.text="You plant three arrows, pointing up and at an angle, in the ground. You are left with three arrows in your quiver. You sit yourself inbetween the three arrows. \n\n"
				+ "You begin your watch. Press S to stand guard over the Golden Apple tree.";
				
				if (Input.GetKeyDown(KeyCode.S))
				{
					myState=States.Stand_Guard_Arrows_Plant;
				}
	}
	
	void state_Stand_Guard_Sword_Bow_and_Arrows ()
	{
		text.text="You begin your watch!\n\n"
			+"Night comes and you eventually fall asleep. The next morning you discover the apples have all gone.\n\n"
				+"Press R to try again";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Examine_Ground_Sword_Bow_and_Arrows()
	{
		text.text="You poke the ground with the sword. It is soft.\n\n"
				+ "Press A to look Away or press P to Plant arrows";
				
				if (Input.GetKeyDown(KeyCode.A))
				{
					myState=States.Garden_eqpd_Sword_Bow_and_Arrows;
				}
				else if (Input.GetKeyDown(KeyCode.P))
				{
					myState=States.Plant_Arrows_eqpd_Sword;
				}
	}
	
	void state_Examine_Tree_Sword_Bow_and_Arrows()
	{
		text.text="You look at the Golden Apples Tree.\n\n"
			+ "Press A to look Away";
		if (Input.GetKeyDown(KeyCode.A))
		{
			myState=States.Garden_eqpd_Sword_Bow_and_Arrows;
		}
	}
	
	void state_View_Spikes_holding_Sword()
	{
		text.text="The Spikes would be useful for mele combat and to poke your eye out if you're careless." 
				+ "What use are the spikes if you already have your father's mighty balaur slaying sword!? \n\n"
				+"Press P to Pick up the Spikes or A to look away";
				
				if (Input.GetKeyDown(KeyCode.P))
				{
					myState=States.Armory_eqpd_Spikes_Sword;
				}
				else if (Input.GetKeyDown(KeyCode.A))
				{
					myState=States.Armory_Sword;
				}
	}
	
	void state_Stand_Guard_Sword()
	{
		text.text="You begin your watch!\n\n"
				+"Night comes and you eventually fall asleep. The next morning you discover the apples have all gone.\n\n"
				+"Press R to try again";
				if (Input.GetKeyDown(KeyCode.R))
				{
					myState=States.Throne_Room;
				}
	}
	
	void state_Examine_Tree_eqpd_Sword() 
	{
		text.text="You look at the Golden Apples Tree.\n\n"
				+ "Press A to look Away";
				if (Input.GetKeyDown(KeyCode.A))
				{
					myState=States.Garden_Sword;
				}
				
	}
	
	void state_Examine_Ground_eqpd_Sword()
	{
		text.text="You poke the ground with the sword. It is soft and no match for your father's mighty balaur slaying blade! \n\n"
			+"Press A to look Away";
			if (Input.GetKeyDown(KeyCode.A))
			{
				myState=States.Garden_Sword;
			}
	}
	
	void state_Garden_eqpd_Sword_Bow_and_Arrows()
	{
		text.text="You are in the Garden. You are equipped with your father's sword and bow and arrows.\n\n"
				+ "Press T to examine the tree, G to examine the Ground or W to begin your Watch.";
				
				if (Input.GetKeyDown(KeyCode.T))
				{
					myState=States.Examine_Tree_Sword_Bow_and_Arrows;
				}
				else if (Input.GetKeyDown(KeyCode.G))
				{
					myState=States.Examine_Ground_Sword_Bow_and_Arrows;
				}
				else if (Input.GetKeyDown(KeyCode.W))
				{
					myState=States.Stand_Guard_Sword_Bow_and_Arrows;
				}
	}

	
	void state_Armory_eqpd_Sword_Bow_and_Arrows ()
	{
		text.text="You secure the Bow and its quiver full of arrows to your back. \n\n"
				+ "You are now equipped with your father's mighty sword and a bow and arrows \n\n"
				+ "Press L to go the Garden or press S to examine the Spikes";
				
				if (Input.GetKeyDown(KeyCode.L))
				{
					myState=States.Garden_eqpd_Sword_Bow_and_Arrows;
				}
				else if (Input.GetKeyDown(KeyCode.S))
				{
					myState=States.View_Spikes_holding_Sword;
				}
	}
	
	void state_View_Bow_and_Arrows_holding_Sword ()
	{
		text.text="The Bow and Arrow would be useful for long range combat, but your aim is pretty weak. \n\n" + 
			"Press R to look away or press B to pick up the Bow and Arrows.";
			
		if (Input.GetKeyDown(KeyCode.R)) 
		{
			myState=States.Armory_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.B))
		{
			myState=States.Armory_eqpd_Sword_Bow_and_Arrows;
		}
	}
	
	void state_Garden_Sword ()
	{
		text.text="You are standing in the Garden armed with your father's mighty balaur-slaying Sword! You feel invincible.\n\n"
			+ "Press T to examine the tree, G to examine the Ground or W to begin your Watch.";
			
		if (Input.GetKeyDown(KeyCode.T))
		{
			myState=States.Examine_Tree_eqpd_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.G))
		{
			myState=States.Examine_Ground_eqpd_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.W))
		{
			myState=States.Stand_Guard_Sword;
		}
			
	}
	
	void state_Armory_Sword ()
	{
		text.text="You secure your father's Sword in its holster, and fasten it around your waist. \n\n"
				+ "Press L to go to the Garden or B to examine the Bow and Arrows or S to exminne the Spikes";
		
		if (Input.GetKeyDown(KeyCode.L))
		{
			myState=States.Garden_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.B))
		{
			myState=States.View_Bow_and_Arrows_holding_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.View_Spikes_holding_Sword;
		}
	}
	
	void state_View_Bow_and_Arrows_holding_Spikes_Sword ()
	{
		text.text="The Bow and Arrow would be useful for long range combat, but your aim is pretty weak. \n\n" + 
			"Press R to look away or press B to pick up the Bow and Arrows.";
		
		if (Input.GetKeyDown(KeyCode.R)) 
		{
			myState=States.Armory_eqpd_Spikes_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.B))
		{
			myState=States.Armory_eqpd_Spikes_Bow_and_Arrows_Sword;
		}
	}
	
	void state_Stand_Guard_No_Plan_All ()
	{
		text.text="You begin your Watch confident in the might of your arsenal! \n\n"+
					"You fall asleep and the apples are stolen yet again \n\n" +
					"Press R to try again";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Fail_All () 
	{
		text.text="You give up. No point in shooting arrows into thin air since it is clear you have rubbish aim.\n\n"
			+ "Press R to try again";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Small_Victory_All_Return ()
	{
		
		text.text="Yeeeeeeeeeeeeees!";
		
	}
	
	void state_Small_Victory_All () 
	{
		text.text="The shadowy figure lets loose a screatching scream! You have hit yout target! The thief flies away, without having stolen the last few apples. \n\n"
			+ "Press V to return to you Father with the good news!";
		
		if (Input.GetKeyDown(KeyCode.V))
		{
			myState=States.Small_Victory_All_Return;
		}
	}
	
	void state_Shoot_Arrows_All ()
	{
		text.text="You shoot arrows at the shadowy figure! In the dim moonlight you manage to almost empty your entire quiver into thin air! You have ONE arrow left! \n\n"
			+ "Press S to shoot or L to Give Up!";
		
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Small_Victory_All;
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			myState=States.Fail_All;
		}
	}
	
	void state_Climb_Tree_All () 
	{
		text.text="You draw your father's mighty Sword and climb the tree, but between its branches you completly loose sight of the Thief and it gets aways. \n\n"
			+ "Press R to return to your soon to be very disappointed Father";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Thief_Arrives_All () 
	{
		text.text="You hear a rustle in the branches. You look up and, in the moonlight, you see the glistening Golden Apples disappearing as a flying shadowy figure swipes them. \n\n"
			+ "Press C to climb up the tree or S to shoot Arrows at the Thief!";
		
		if (Input.GetKeyDown(KeyCode.C))
		{
			myState=States.Climb_Tree_All; 
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Shoot_Arrows_All; 
		}
	}
	
	void state_Fall_Asleep_All () 
	{
		text.text="You decide to call it a day and try again tomorrow night. The next morning the last few Golden Apples left are gone. \n\n"
				+ "Press R to try again";
				
				if (Input.GetKeyDown(KeyCode.R))
				{
					myState=States.Throne_Room;
				}
	}
	
	void state_Stand_Guard_All () 
	{
		text.text="The sun sets and you find yourself well into the late hours of the night. You often fall to the side from exhaustion, but the spikes prick you back awake. The Thief has yet to arrive. \n\n"
				+ "Press L to give up or P to Push forward";
		
		if (Input.GetKeyDown(KeyCode.L))
		{
			myState=States.Fall_Asleep_All;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Thief_Arrives_All; 
		}
	}
	
	void state_Plant_Spikes_All () 
	{
		text.text="You have  planted the spikes, at an angle and pointing up \n\n" 
			+ "Press P to pick up your spikes or S to Stand guard in between them";
		
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Stand_Guard_All;
		}
	}
	
	void state_Examine_Ground_All ()
	{
		text.text="You poke the ground with your father's Sword. It is soft\n\n"
				+ "Press R to return or press P to plant Spikes";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Garden_eqpd_Spikes_Bow_and_Arrows_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Plant_Spikes_All;
		}
	}
	
	void state_Examine_Tree_All () 
	{
		text.text="You look at the Golden Apples tree \n\n"+
					"Press A to look away.";
		if (Input.GetKeyDown(KeyCode.A))
		{
			myState=States.Garden_eqpd_Spikes_Bow_and_Arrows_Sword;
		}
	}
	
	void state_Garden_eqpd_Spikes_Bow_and_Arrows_Sword() 
	{
		text.text="You are in the Garden armed to the teeth and ready to catch the Golden Apples Thief!.\n\n"
			+ "Press R to Return to the Throne Room, T to examine the Tree, G to examine the Ground or S to Stand guard";
		
		if (Input.GetKeyDown(KeyCode.T))
		{
			myState=States.Examine_Tree_All;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
		else if (Input.GetKey(KeyCode.G))
		{
			myState=States.Examine_Ground_All;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Stand_Guard_No_Plan_All;
		}
	}
	
	void state_Armory_eqpd_Spikes_Bow_and_Arrows_Sword()
	{
		text.text="You are fully equipped and unstoppable! \n\n"
				+ "Press L to go to the Garden and begin your Watch!";
				
				if (Input.GetKeyDown(KeyCode.L))
				{
					myState=States.Garden_eqpd_Spikes_Bow_and_Arrows_Sword;
				}
	}
	
	void state_View_Sword_holding_Spikes_Bow_and_Arrows()
	{
		text.text="It is your father's sword! The mighty sword that vanquished all the balaurs!!! \n\n" + 
			"Press R to look away or P to Pick-up the Sword";
		
		if (Input.GetKeyDown(KeyCode.R)) 
		{
			myState=States.Armory_eqpd_Spikes_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Armory_eqpd_Spikes_Bow_and_Arrows_Sword;
		}
	}
	
	void state_Fail_Spikes_Bow_and_Arrows() 
	{
		text.text="You give up. No point in shooting arrows into thin air since it is clear you have rubbish aim.\n\n"
				+ "Press R to try again";
				
				if (Input.GetKeyDown(KeyCode.R))
				{
					myState=States.Throne_Room;
				}
	}
	
	void state_Small_Victory_Spikes_Bow_and_Arrows_Return() 
	{
		text.text="Yeeeeeeeeeeeeees!";
	}
	
	void state_Small_Victory_Spikes_Bow_and_Arrows()
	{
		text.text="The shadowy figure lets loose a screatching scream! You have hit yout target! The thief flies away, without having stolen the last few apples. \n\n"
				+ "Press V to return to you Father with the good news!";
				
				if (Input.GetKeyDown(KeyCode.V))
				{
					myState=States.Small_Victory_Spikes_Bow_and_Arrows_Return;
				}
	}
	
	void state_Shoot_Arrows()
	{
		text.text="You shoot arrows at the shadowy figure! In the dim moonlight you manage to almost empty your entire quiver into thin air! You have ONE arrow left! \n\n"
				+ "Press S to shoot or L to Give Up!";
				
				if (Input.GetKeyDown(KeyCode.S))
				{
					myState=States.Small_Victory_Spikes_Bow_and_Arrows;
				}
				else if (Input.GetKeyDown(KeyCode.L))
				{
					myState=States.Fail_Spikes_Bow_and_Arrows;
				}
	}
	
	void state_Climb_Tree_Spikes_Bow_and_Arrows() 
	{
		text.text="You climb the tree, but between its branches you completly loose sight of the Thief and he gets aways. \n\n"
			+ "Press R to return to your soon to be very disappointed Father";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Thief_Arrives_Spikes_Bow_and_Arrows()
	{
		text.text="You hear a rustle in the branches. You look up and, in the moonlight, you see the glistening Golden Apples disappearing as a flying shadowy figure swipes them. \n\n"
			+ "Press C to climb up the tree or S to shoot Arrows at the Thief!";
		
		if (Input.GetKeyDown(KeyCode.C))
		{
			myState=States.Climb_Tree_Spikes_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Shoot_Arrows; 
		}
	}
	
	void state_Stand_Guard_Spikes_Bow_and_Arrows()
	{
		text.text="The sun sets and you find yourself well into the late hours of the night. You often fall to the side from exhaustion, but the spikes prick you back awake. The Thief has yet to arrive. \n\n"
			+ "Press L to give up or P to Push forward";
		
		if (Input.GetKeyDown(KeyCode.L))
		{
			myState=States.Fall_Asleep_Spikes_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Thief_Arrives_Spikes_Bow_and_Arrows;
		}
	}
	
	
	void state_Fall_Asleep_Spikes_Bow_and_Arrows() 
	{
		text.text="You begin your Watch! \n\n"+
			"You fall asleeps and the apples are stolen yet again \n\n" +
				"Press R to try again";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Plant_Spikes_Bow_and_Arrows() 
	{
		text.text="You have  planted the spikes, at an angle and pointing up \n\n" 
			+ "Press P to pick up your spikes or S to Stand guard in between them";
		
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Stand_Guard_Spikes_Bow_and_Arrows;
		}
	}
	
	void state_Examine_Ground_Spikes_Bow_and_Arrows() 
	{
		text.text="You poke the ground with one Spike. The Spike penetrates the ground rather easily and \n\n" 
				+ "remains prompted when you let go of it. \n\n" 
				+ "Press R to look away or P to Plant the other two spikes";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Garden_eqpd_Spikes_Bow_and_Arrows;
		}
		else if (Input.GetKey(KeyCode.P))
		{
			myState=States.Plant_Spikes_Bow_and_Arrows;
		}
	}
	
	void state_Examine_Tree_Spikes_Bow_and_Arrows()
	{
		text.text="You look at the Golden Apples tree \n\n"+
			"Press A to look away.";
		if (Input.GetKeyDown(KeyCode.A))
		{
			myState=States.Garden_eqpd_Spikes_Bow_and_Arrows;
		}
	}
	void state_Garden_eqpd_Spikes_Bow_and_Arrows()
	{
		text.text="You are in the Garden with Spikes and Bow and Arrows.\n\n"
			+ "Press R to Return to the Throne Room, T to examine the Tree, G to examine the Ground or S to Stand guard";
		
		if (Input.GetKeyDown(KeyCode.T))
		{
			myState=States.Examine_Tree_Spikes_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
		else if (Input.GetKey(KeyCode.G))
		{
			myState=States.Examine_Ground_Spikes_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Fall_Asleep_Spikes_Bow_and_Arrows;
		}
	}
	
	void state_Armory_eqpd_Spikes_Bow_and_Arrows() 
	{
		text.text="You secure the Bow and Arrows on your back. \n\n"
			+ "You are now equiped with three spikes on your right side and a bow and arrow on your back. \n\n"
				+ "Press L to go to the Garden or Press S to view Sword";
		
		if (Input.GetKeyDown(KeyCode.L))
		{
			myState=States.Garden_eqpd_Spikes_Bow_and_Arrows;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.View_Sword_holding_Spikes_Bow_and_Arrows;
		}
	}
	
	void state_View_Bow_and_Arrows_holding_Spikes()
	{
		text.text="The Bow and Arrow would be useful for long range combat, but your aim is weak. \n\n" + 
			"Press R to look away or P to Pick-up the Bow and Arrows";
		
		if (Input.GetKeyDown(KeyCode.R)) 
		{
			myState=States.Armory_eqpd_Spikes;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Armory_eqpd_Spikes_Bow_and_Arrows;
		}
	}
	
	void state_Fall_Asleep_Spikes_Sword() 
	{
		text.text="You begin your Watch! \n\n"+
			"You fall asleeps and the apples are stolen yet again \n\n" +
				"Press R to try again";
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Climb_Tree_Sword()
	{
		text.text="You draw your father's mighty Sword and climb the tree, but between its branches you completly loose sight of the Thief and he gets aways. \n\n"
			+ "Press R to return to your soon to be very disappointed Father";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Thief_Arrives_Spikes_Sword()
	{
		text.text="You hear a rustle in the branches. You look up and, in the moonlight, you see the glistening Golden Apples disappearing as a flying shadowy figure swipes them. \n\n"
			+ "Press C to climb up the tree or T to throw the Spikes at the Thief!";
		
		if (Input.GetKeyDown(KeyCode.C))
		{
			myState=States.Climb_Tree_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.T))
		{
			myState=States.Throw_Spikes;
		}
	}
	
	void state_Stand_Guard_Spikes_Sword()
	{
		text.text="The sun sets and you find yourself well into the late hours of the night. You often fall to the side from exhaustion, but the spikes prick you back awake. The Thief has yet to arrive. \n\n"
			+ "Press L to give up or P to Push forward";
		
		if (Input.GetKeyDown(KeyCode.L))
		{
			myState=States.Fall_Asleep;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Thief_Arrives_Spikes_Sword;
		}
	}
	
	void state_Plant_Spikes_Sword() 
	{
		text.text="You have  planted the spikes, at an angle and pointing up \n\n" 
			+ "Press P to pick up your spikes or S to Stand guard in between them";
			
			if (Input.GetKeyDown(KeyCode.S))
			{
				myState=States.Stand_Guard_Spikes_Sword;
			}
			
			
	}
	
	void state_Examine_Tree_Sword()
	{
		text.text="You look at the Golden Apples tree \n\n"+
			"Press A to look away.";
		if (Input.GetKeyDown(KeyCode.A))
		{
			myState=States.Garden_eqpd_Spikes_Sword;
		}
	}
	
	void state_Examine_Ground_Sword() 
	{
		text.text="You poke the ground with your father's Sword. It is soft\n\n"
				+ "Press R to return or press P to plant Spikes";
				
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Garden_eqpd_Spikes_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Plant_Spikes_Sword;
		}
	}
	
	void state_Garden_eqpd_Spikes_Sword() 
	{
		text.text="You are in the Garden.\n\n"
				+ "Press R to Return to the Throne Room, T to examine the Tree, G to examine the Ground or S to Stand guard";
			
			if (Input.GetKeyDown(KeyCode.T))
			{
				myState=States.Examine_Tree_Sword;
			}
			else if (Input.GetKeyDown(KeyCode.R))
			{
				myState=States.Throne_Room;
			}
			else if (Input.GetKey(KeyCode.G))
			{
				myState=States.Examine_Ground_Sword;
			}
			else if (Input.GetKeyDown(KeyCode.S))
			{
				myState=States.Fall_Asleep_Spikes_Sword;
			}
	}
	
	void state_Armory_eqpd_Spikes() 
	{
		text.text="You secure your three spikes to your belt. You return your gaze to the Armory wall.\n\n"
				+ "Press G to go to the Garden, S to examine the Sword or B to examine the Bow and Arrows";
				
				if (Input.GetKeyDown(KeyCode.G))
				{
					myState=States.Garden_Spikes;
				}
				else if (Input.GetKeyDown(KeyCode.S))
				{
					myState=States.View_Sword_holding_Spikes;
				}
				else if (Input.GetKeyDown(KeyCode.B))
				{
					myState=States.View_Bow_and_Arrows_holding_Spikes;
				}
	}
	
	void state_View_Sword_holding_Spikes() 
	{
		text.text="It is your father's sword! The mighty sword that vanquished all the balaurs!!! \n\n" + 
			"Press R to look away or P to Pick-up the Sword";
		
		if (Input.GetKeyDown(KeyCode.R)) 
		{
			myState=States.Armory;
		}
		else if (Input.GetKeyDown(KeyCode.P))
		{
			myState=States.Armory_eqpd_Spikes_Sword;
		}
	}
	
	void state_Armory_eqpd_Spikes_Sword() 
	{
		text.text="You secure your father's Sword in its holster, and fasten it around your waist."
				+ "You are now equiped with three spikes on your right side and one sword on your left side. \n\n"
				+ "Press L to go to the Garden or B to examine the Bow and Arrows";
				
		if (Input.GetKeyDown(KeyCode.L))
		{
			myState=States.Garden_eqpd_Spikes_Sword;
		}
		else if (Input.GetKeyDown(KeyCode.B))
		{
			myState=States.View_Bow_and_Arrows_holding_Spikes_Sword;
		}
	}
	
	void state_Throne_Room () 
	{
		text.text="You are in the Throne Room \n\n"+
			"Press L to go to the Library, G to go to the Garden and A to go to the Armory" ;
		if (Input.GetKeyDown(KeyCode.G)) 
		{
			myState=States.Garden;
		} 
		else if (Input.GetKeyDown(KeyCode.L)) 
		{
			myState=States.Library;
		}
		else if (Input.GetKeyDown(KeyCode.A)) 
		{
			myState=States.Armory;
		}
	}
	
	void state_garden ()
	{
			text.text="You are in the Garden \n\n" +
						"Press R to Return to the Throne Room, T to examine the Tree, G to examine the Ground or S to Stand guard";
			
			if (Input.GetKeyDown(KeyCode.R))
			{
				myState=States.Throne_Room;
			} 
			else if (Input.GetKeyDown(KeyCode.G))
			{
				myState=States.Examine_Ground; 
			}
			else if (Input.GetKeyDown(KeyCode.T))
			{
				myState=States.Examine_Tree;
			}
			else if (Input.GetKeyDown(KeyCode.S))
			{
				myState=States.Fall_Asleep;
			}
	}
	
	void state_Examine_Ground_Spikes() 
	{
		text.text="You poke the ground with one Spike. The Spike penetrates the ground rather easily and" 
				+ "remains prompted when you let it go \n\n" 
				+ "Press R to look away or P to Plant the other two spikes";
				
				if (Input.GetKeyDown(KeyCode.R))
				{
					myState=States.Garden_Spikes;
				}
				else if (Input.GetKey(KeyCode.P))
				{
					myState=States.Plant_Spikes;
				}
	}
	
	void state_Plant_Spikes() 
	{
		text.text="You have planted the spikes, at an angle and pointing up \n\n" 
				+ "Press P to pick up your spikes or S to Stand guard in between them";
				
				if (Input.GetKeyDown(KeyCode.P))
				{
					myState=States.Garden_Spikes;
				}
				else if (Input.GetKeyDown(KeyCode.S))
				{
					myState=States.Stand_Guard_Spikes;
				}
	}
	
	void state_Stand_Guard_Spikes()
	{
		text.text="The sun sets and you find yourself well into the late hours of the night. You often fall to the side from exhaustion, but the spikes prick you back awake. The Thief has yet to arrive. \n\n"
				+ "Press L to give up or P to Push forward";
				
				if (Input.GetKeyDown(KeyCode.L))
				{
					myState=States.Fall_Asleep;
				}
				else if (Input.GetKeyDown(KeyCode.P))
				{
					myState=States.Thief_Arrives;
				}
	}
	
	void state_Thief_Arrives() 
	{
		text.text="You hear a rustle in the branches. You look up and, in the moonlight, you see the glistening Golden Apples disappearing as a flying shadowy figure swipes them. \n\n"
				+ "Press C to climb up the tree or T to throw the Spikes at the Thief!";
				
				if (Input.GetKeyDown(KeyCode.C))
				{
					myState=States.Climb_Tree;
				}
				else if (Input.GetKeyDown(KeyCode.T))
				{
					myState=States.Throw_Spikes;
				}
	}
	
	void state_Climb_Tree() 
	{
		text.text="You climb the tree, but between its branches you completly loose sight of the Thief and he gets aways. \n\n"
				+ "Press R to return to your soon to be very disappointed Father";
				
				if (Input.GetKeyDown(KeyCode.R))
				{
					myState=States.Throne_Room;
				}
	}
	
	void state_Throw_Spikes() 
	{
		text.text="You throw the Spikes, but your aim is poor and the Thief escapes unharmed with your Father's Golden Apples.\n\n"
			+ "Press R to return to your soon to be very disappointed Father";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		}
	}
	
	void state_Garden_Spikes() 
	{
		text.text="You are in the Garden equipped with your Spikes \n\n" +
			"Press R to Return to the Throne Room, T to examine the Tree, G to examine the Ground or S to Stand guard";
			
				if (Input.GetKeyDown(KeyCode.R))
		{
			myState=States.Throne_Room;
		} 
		else if (Input.GetKeyDown(KeyCode.G))
		{
			myState=States.Examine_Ground;
		}
		else if (Input.GetKeyDown(KeyCode.T))
		{
			myState=States.Examine_Tree;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState=States.Fall_Asleep;
		}
	}
	
	void state_Library () 
	{
			text.text="You are in the Library \n\n" +
						"Press R to return to the Throne Room";
						
			if (Input.GetKeyDown(KeyCode.R)) 
			{
				myState=States.Throne_Room;
			}
			
	}
	
	void state_Armory() 
	{
			text.text="You are now in the Armory \n\n" +
						"On the wall there is a Sword, a Bow with Arrows and Spikes\n\n" +
						"Press S to examine Sword. Press B to examine Bow and Arrows. Press P to examine Spikes. \n\n" +						
						"Press R to return to the Throne Room";
			if (Input.GetKeyDown(KeyCode.R))
			{
				myState=States.Throne_Room;
			}
			else if (Input.GetKeyDown(KeyCode.B))
			{
				myState=States.Bow_and_Arrows;
			}
			else if (Input.GetKeyDown(KeyCode.S))
			{
				myState=States.Sword;
			}
			else if (Input.GetKeyDown(KeyCode.P))
			{
				myState=States.Spikes;
			}
	}
	
	void state_Armory_Spikes() 
	{
		text.text="You pick up the Spikes, having decided not to poke your eyes out. \n\n" +
					"Press G to go to the Garden or R to Return to Armory";
					if (Input.GetKeyDown(KeyCode.G))
					{
						myState=States.Garden;
					} 
					else if (Input.GetKeyDown(KeyCode.R)) 
					{
						myState=States.Armory_eqpd_Spikes;
					}
	}
	
	void state_Sword() 
	{
		text.text="It is your father's sword! The mighty sword that vanquished all the balaurs!!! \n\n" + 
					"Press R to look away or P to Pick-up the Sword";
						
			if (Input.GetKeyDown(KeyCode.R)) 
			{
				myState=States.Armory;
			}
			else if (Input.GetKeyDown(KeyCode.P))
			{
				myState=States.Armory_Sword;
			}
						
	}
	
	void state_Bow_and_Arrow() 
	{
		text.text="The Bow and Arrow would be useful for long range combat \n\n" + 
				"Press R to look away or P to Pick-up the bow and arrows.";
			
			if (Input.GetKeyDown(KeyCode.R)) 
			{
				myState=States.Armory;
			}
			else if (Input.GetKeyDown(KeyCode.P))
			{
				myState=States.Armory_eqpd_Bow_and_Arrows;
			}
	}
	
	void state_Spikes() 
	{
		text.text="The Spikes would be useful for mele combat and to poke your eye out if you're careless \n\n" + 
				"Press R to look away or press P to Pick-up Spikes";
			
			if (Input.GetKeyDown(KeyCode.R)) 
			{
				myState=States.Armory;
			} 
			else if (Input.GetKeyDown(KeyCode.P)) 
			{
				myState=States.Armory_Spikes;
			}
	}
	
	void state_Examine_Tree()
	{
			text.text="You examine the tree  \n\n"+
						"Press R to look away";
			if (Input.GetKeyDown(KeyCode.R))
			{
				myState=States.Garden;
			}
	}
	
	void state_Examine_Ground() 
	{
			text.text="You stomp the ground, searching for a soft spot to camp out overnight.\n\n" + 
						"The ground is pretty soft from yesterday's heavy rain.\n\n" +
						"Press R to look away";
						
			if (Input.GetKeyDown(KeyCode.R))
			{
				myState=States.Garden;
			}
	}
	
	void state_Fall_Sleep() 
	{
			text.text="You begin your watch! \n\n"+
						".... but you fall asleep and the apples are stolen yet again \n\n" +
						"Press R to try again";
			if (Input.GetKeyDown(KeyCode.R))
			{
				myState=States.Throne_Room;
			}
	}
}
