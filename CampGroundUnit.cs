using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAalborgCamping
{
	public abstract class CampGroundUnit
	{

		public int maxUnitNumber { get; private set; }
		public int nofUnitsLeft { get; private set; }
		private List<int> unitsList;


		// Constructure
		public CampGroundUnit(int nof_items)
		{
			unitsList = new List<int> { }; // Initialize private unit list
			nofUnitsLeft = nof_items; // Initialize counter to keep information about unit left
			maxUnitNumber = nof_items; // Initialize Max unit number

			// Initialize place numbers to the list
			for (int i = 1; i <= nof_items; i++)
			{
				unitsList.Add(i);
			}
		}


		// Methode to freeadd an item by remove it from the list, so the list only contain free place numbers
		public bool RemoveItemsFromUnitList(int number)
		{
			// Check place is free by going the the units list [counter]
			for (int i = 0; i < nofUnitsLeft; i++)
			{
				if (unitsList[i] == number)
				{
					unitsList.Remove(number);
					nofUnitsLeft--;
					return true;
				}
			}

			return false;
		}
	
		// Methode : When guest checkout we add the number again to unit list.
		public void AddItemsToUnitList(int number)
		{
			bool NumberExist = false;

			// Går igennem listen af _units for at se om number allerede findes, 
			// hvis ja, bliver NumberExit sat til true
			for (int i = 0; i < unitsList.Count; i++)
			{
				if (unitsList[i] == number)
				{
					NumberExist = true;
					break;
				}
			}

			// Kontrollere om NumberExist findes allerede, hvis ikke bliver det tilføjet.
			if (NumberExist == false) 
			{
				unitsList.Add(number);
				nofUnitsLeft++;
			}

		}

		/*********************************************************************
		 * Methode: AskForItem
		 * Input: number
		 * output: bool
		 * Description: Run through the list of unit to see if the number are
		 * in the unit list. If yes, then return true otherwise return false
		 *********************************************************************/
		public bool AskForUnitInList(int number)
		{
			for (int i = 0; i < unitsList.Count; i++)
			{
				if (unitsList[i] == number)
				{
					return true;
				}
			}
			return false;
		}
	}
}
