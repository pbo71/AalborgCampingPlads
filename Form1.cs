using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAalborgCamping
{
	public partial class Form1 : Form
	{

		public CampGround campGround;
		int IdNumber;

		public Form1()
		{
			
			InitializeComponent();
			campGround = new CampGround(130, 8, 5, 2);

			this.ActiveControl = txtBoxName;
			toolStripStatusLabelTentPlace.Text = "Antal ledige teltpladser: " + campGround.pitch.nofUnitsLeft.ToString();
			toolStripStatusLabelSmallCabin.Text = "Antal ledige små hytter: " + campGround.smallBungalow.nofUnitsLeft.ToString();
			toolStripStatusLabelBigCabin.Text = "Antal ledige store hytter: " + campGround.bigBungalow.nofUnitsLeft.ToString();
			toolStripStatusLabelLuxuryCabin.Text = "Antal ledige luksus hytter: " + campGround.luxuryBungalow.nofUnitsLeft.ToString();
			CountNofPeople(); // Update statusbar with numbers of people checked in

			listView1.View = View.Details;
			listView1.Columns.Add("Res ID", 50, HorizontalAlignment.Left);
			listView1.Columns.Add("Navn", 150, HorizontalAlignment.Left);
			listView1.Columns.Add("Voksne", 50, HorizontalAlignment.Left);
			listView1.Columns.Add("Børn", 50, HorizontalAlignment.Left);
			listView1.Columns.Add("Dyr", 50, HorizontalAlignment.Left);
			listView1.Columns.Add("Hytte type",75, HorizontalAlignment.Left);
			listView1.Columns.Add("Hytte nr.", 75, HorizontalAlignment.Left);
			listView1.Columns.Add("Teltplads nr.", 75, HorizontalAlignment.Left);

			IdNumber = 0;

		}

		private void CountNofPeople()
		{
			// Methode to count the number of people and update statusbar with this information
			int NofOfAdult = 0;
			int NofOfKids = 0;

			for (int i = 0; i < campGround.ReservationList.Count; i++) // Go through all item in list an count adult and kids.
			{
				NofOfKids = NofOfKids + campGround.ReservationList[i].Kids;
				NofOfAdult = NofOfAdult + campGround.ReservationList[i].Adults;
			}

			toolStripStatusLabelAdults.Text = string.Format("Antal voksne: {0}", NofOfAdult);
			toolStripStatusLabelKids.Text = string.Format("Antal børn: {0}", NofOfKids); 
		}


		private void ShowOkMessage(string message)
		{
			const string caption = "CheckIn";
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ShowErrorMessage(string message)
		{
			const string captionError = "CheckIn";
			MessageBox.Show(message, captionError,
										 MessageBoxButtons.OK,
										 MessageBoxIcon.Error);
		}

		private void ShowMessage(string message, string caption)
		{
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}



		private void omToolStripMenuItem_Click(object sender, EventArgs e)
		{

			AboutBoxAalborgCamping about = new AboutBoxAalborgCamping();
			about.Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult iExit;

			iExit = MessageBox.Show("Vil du lukke programmet", "Afslut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (iExit == DialogResult.Yes)
			{
				Application.Exit();
			}

		}

		private void btnCheckIn_Click(object sender, EventArgs e)
		{
			bool FreeUnit = false;
			int TentPlaceNumber = 0; // Initialize Tent place number
			int CabinNumber = 0; // initialize cabin number

			CampGroundReservationsInfo Guest = new CampGroundReservationsInfo();

			IdNumber++;
					   			 
			IEnumerable<RadioButton> buttons = groupBoxCabinTent.Controls.OfType<RadioButton>();
			Guest.Id = IdNumber.ToString("0000");
			// Add guest name
			Guest.Name = txtBoxName.Text;
			// Get numbers of Adults
			Guest.Adults = Convert.ToInt32(numericUpDownAdult.Value);
			// Get numbers of kids
			Guest.Kids = Convert.ToInt32(numericUpDownKids.Value);
			// Animal ? true | false
			Guest.Animal = checkBoxAnimal.Checked;
			// Find ud af hvilken radio button som er valgt
			foreach (var radioBtn in buttons)
			{
				if (radioBtn.Name == "radioBtnTentPlace" && radioBtn.Checked == true)
				{
					TentPlaceNumber = Convert.ToInt32(numericUpDownTent.Value);

					// Test tent place is a legal number
					if (TentPlaceNumber > campGround.pitch.maxUnitNumber || TentPlaceNumber < 1)
					{
						ShowErrorMessage("Ugyldig teltplads nummer");
						break;
					}
									
					if (campGround.pitch.RemoveItemsFromUnitList(TentPlaceNumber) == true) 
					{
						Guest.SiteNumber = TentPlaceNumber;
						Guest.BungalowNumber = 0;
						Guest.BungalowType = CampGroundReservationsInfo.BungaLowTypes.Ingen;
						
						campGround.ReservationList.Add(Guest);
						toolStripStatusLabelTentPlace.Text = string.Format("Antal ledige teltpladser:{0}",campGround.pitch.nofUnitsLeft); 
						ShowMessage(string.Format("Reservation af familie: {0} på teltplads nummer {1} fuldført",Guest.Name, TentPlaceNumber),"Reservation");
						txtBoxName.Text = "";
						numericUpDownAdult.Value = 0;
						numericUpDownKids.Value = 0;
						checkBoxAnimal.Checked = false;
					}
					else
					{
						ShowErrorMessage("Noget gik galt, måske er teltpladsen optaget ?");
					}
					break;
				}

				if (radioBtn.Name == "radioBtnSmallCabin" && radioBtn.Checked == true)
				{
					CabinNumber = Convert.ToInt32(numericUpDownSmallCabin.Value);
					// Check cabin with "CabinNumber is free
					FreeUnit = campGround.smallBungalow.RemoveItemsFromUnitList(CabinNumber);
					if (FreeUnit == true)
					{
						Guest.SiteNumber = TentPlaceNumber;
						Guest.BungalowNumber = CabinNumber;
						Guest.BungalowType = CampGroundReservationsInfo.BungaLowTypes.Lille;
												
						campGround.ReservationList.Add(Guest);
						toolStripStatusLabelSmallCabin.Text = string.Format("Antal ledige små hytter: {0}", campGround.smallBungalow.nofUnitsLeft);
						ShowMessage(string.Format("Reservation af familie: {0} i hytte type: {1} og hytte nr.{2} fuldført", Guest.Name,Guest.BungalowType,CabinNumber),"Reservation");
						txtBoxName.Text = "";
						numericUpDownAdult.Value = 0;
						numericUpDownKids.Value = 0;
						checkBoxAnimal.Checked = false;

					}
					else
					{
						ShowErrorMessage("Noget gik galt, måske hytten er optaget ?");
					}

					break;
				}

				if (radioBtn.Name == "radioBtnBigCabin" && radioBtn.Checked == true)
				{
					CabinNumber = Convert.ToInt32(numericUpDownBigCabin.Value);
					// Check Cabin Number is free
					FreeUnit = campGround.bigBungalow.RemoveItemsFromUnitList(CabinNumber);

					if (FreeUnit == true)
					{
						Guest.SiteNumber = TentPlaceNumber;
						Guest.BungalowNumber = CabinNumber;
						Guest.BungalowType = CampGroundReservationsInfo.BungaLowTypes.Stor;
						campGround.ReservationList.Add(Guest);
						toolStripStatusLabelBigCabin.Text = string.Format("Antal ledige store hytter: {0}", campGround.bigBungalow.nofUnitsLeft);
						ShowMessage(String.Format("Reservation af familie: {0} i hytte nr.{1} fuldført", Guest.Name,CabinNumber),"Reservation");
						txtBoxName.Text = "";
						numericUpDownAdult.Value = 0;
						numericUpDownKids.Value = 0;
						checkBoxAnimal.Checked = false;

					}
					else
					{
						ShowErrorMessage("Noget gik galt, måske hytten er optaget ?");
					}

					break;
				}

				if (radioBtn.Name == "radioBtnLuxuryCabin" && radioBtn.Checked == true)
				{
					CabinNumber = Convert.ToInt32(numericUpDownLuxuryCabin.Value);
					// Check Cabin Number is free
					FreeUnit = campGround.luxuryBungalow.RemoveItemsFromUnitList(CabinNumber);

					if (FreeUnit == true)
					{
						Guest.SiteNumber = TentPlaceNumber;
						Guest.BungalowNumber = CabinNumber;
						Guest.BungalowType = CampGroundReservationsInfo.BungaLowTypes.Luksus;
						campGround.ReservationList.Add(Guest);
						toolStripStatusLabelLuxuryCabin.Text = string.Format("Antal ledige luksus hytter: {0}", campGround.luxuryBungalow.nofUnitsLeft);
						ShowMessage(string.Format("Reservation af familie: {0} i hytte nr.{1} fuldført", Guest.Name, CabinNumber),"Reservation");
						txtBoxName.Text = "";
						numericUpDownAdult.Value = 0;
						numericUpDownKids.Value = 0;
						checkBoxAnimal.Checked = false;

					}
					else
					{
						ShowErrorMessage("Noget gik galt, måske hytten er optaget ?");
					}
					break;
				}
			}

			CountNofPeople();
		}

		private void btnAsk_Click(object sender, EventArgs e)
		{

			// Lave en forespørgelse om teltplads eller hytte er ledig

			if (radioBtnTentPlace.Checked == true)
			{
				if(campGround.pitch.AskForUnitInList(Convert.ToInt32(numericUpDownTent.Value)) == true)
				{
					ShowMessage(string.Format("Teltplads nummer: {0} er ledigt", numericUpDownTent.Value), "Forespørgelse");
				}
				else
				{
					ShowMessage(String.Format("Teltplads nummer : {0} er IKKE ledigt", numericUpDownTent.Value), "Forespørgelse");
				}
			}
			else if (radioBtnSmallCabin.Checked == true)
			{
				if (campGround.smallBungalow.AskForUnitInList(Convert.ToInt32(numericUpDownSmallCabin.Value)) == true)
				{
					ShowMessage(string.Format("Lille hytte nummer: {0} er ledigt", numericUpDownSmallCabin.Value), "Forespørgelse");
				}
				else
				{
					ShowMessage(String.Format("Lille hytte nummer : {0} er IKKE ledigt", numericUpDownSmallCabin.Value), "Forespørgelse");
				}
			}
			else if (radioBtnBigCabin.Checked == true)
			{
				if (campGround.bigBungalow.AskForUnitInList(Convert.ToInt32(numericUpDownBigCabin.Value)) == true)
				{
					ShowMessage(string.Format("Stor hytte nummer: {0} er ledigt", numericUpDownBigCabin.Value), "Forespørgelse");
				}
				else
				{
					ShowMessage(String.Format("Stor hytte nummer : {0} er IKKE ledigt", numericUpDownBigCabin.Value), "Forespørgelse");
				}
			}
			else if (radioBtnLuxuryCabin.Checked == true)
			{
				if (campGround.luxuryBungalow.AskForUnitInList(Convert.ToInt32(numericUpDownLuxuryCabin.Value)) == true)
				{
					ShowMessage(string.Format("Luksus hytte nummer: {0} er ledigt", numericUpDownLuxuryCabin.Value), "Forespørgelse");
				}
				else
				{
					ShowMessage(String.Format("Luksus hytte nummer : {0} er IKKE ledigt", numericUpDownLuxuryCabin.Value), "Forespørgelse");
				}
			}
		}

		private void btnStatus_Click(object sender, EventArgs e)
		{
			string Cabin;
			string Animal;

			listView1.Clear();
			listView1.View = View.Details;
			listView1.Columns.Add("Res ID", 50, HorizontalAlignment.Left);
			listView1.Columns.Add("Navn", 150, HorizontalAlignment.Left);
			listView1.Columns.Add("Voksne", 50, HorizontalAlignment.Left);
			listView1.Columns.Add("Børn", 50, HorizontalAlignment.Left);
			listView1.Columns.Add("Dyr", 50, HorizontalAlignment.Left);
			listView1.Columns.Add("Hytte type", 75, HorizontalAlignment.Left);
			listView1.Columns.Add("Hytte nr.", 75, HorizontalAlignment.Left);
			listView1.Columns.Add("Teltplads nr.", 75, HorizontalAlignment.Left);


			if (campGround.ReservationList.Count == 0) // Er der gæster på pladsen ?
			{
				ShowMessage("Der er ingen gæster på campingpladsen", "Gæste information");
			}
			else
			{
				for (int i = 0; i < campGround.ReservationList.Count; i++) // List our guest checkin
				{
					switch (campGround.ReservationList[i].BungalowType)
					{
						case CampGroundReservationsInfo.BungaLowTypes.Lille:
							Cabin = "Lille";
							break;

						case CampGroundReservationsInfo.BungaLowTypes.Stor:
							Cabin = "Stor";
							break;

						case CampGroundReservationsInfo.BungaLowTypes.Luksus:
							Cabin = "Luksus";
							break;

						case CampGroundReservationsInfo.BungaLowTypes.Ingen:
							Cabin = "Ingen";
							break;

						default:
							Cabin = "Ingen";
							break;
					}

					if (campGround.ReservationList[i].Animal == true)
					{
						Animal = "Ja";
					}
					else
					{
						Animal = "Nej";
					}

					listView1.GridLines = true;
					ListViewItem item = new ListViewItem(campGround.ReservationList[i].Id);
					item.SubItems.Add(campGround.ReservationList[i].Name);
					item.SubItems.Add(Convert.ToString(campGround.ReservationList[i].Adults));
					item.SubItems.Add(Convert.ToString(campGround.ReservationList[i].Kids));
					item.SubItems.Add(Animal);
					item.SubItems.Add(Cabin);
					item.SubItems.Add(Convert.ToString(campGround.ReservationList[i].BungalowNumber));
					item.SubItems.Add(Convert.ToString(campGround.ReservationList[i].SiteNumber));
					listView1.Items.Add(item);
				}
			}
		}

		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			int PlaceNumber = 0;
			IEnumerable<RadioButton> buttons = groupBoxCabinTent.Controls.OfType<RadioButton>();

			// Find ud af hvilken radio button som er valgt
			foreach (var radioBtn in buttons)
			{
				if (radioBtn.Name == "radioBtnTentPlace" && radioBtn.Checked == true)
				{
					PlaceNumber = Convert.ToInt32(numericUpDownTent.Value);
					// Kontrollere at telt plads er et gyldig nummer;

					if (PlaceNumber > campGround.pitch.maxUnitNumber)
					{
						ShowErrorMessage("Ugyldig teltplads nummer");
						break;
					}
					else
					{
						campGround.pitch.AddItemsToUnitList(PlaceNumber);
						for (int i = 0; i < campGround.ReservationList.Count; i++)
						{
							if (campGround.ReservationList[i].SiteNumber == PlaceNumber)
							{
								campGround.ReservationList.RemoveAt(i); // Remove Guest from list
								toolStripStatusLabelTentPlace.Text = string.Format("Antal ledige teltpladser:{0}", campGround.pitch.nofUnitsLeft);
							}
						}
					}
				}
				else if (radioBtn.Name == "radioBtnSmallCabin" && radioBtnSmallCabin.Checked == true)
				{
					PlaceNumber = Convert.ToInt32(numericUpDownSmallCabin.Value);

					if (PlaceNumber > campGround.smallBungalow.maxUnitNumber)
					{
						ShowErrorMessage("Ugyldig Hytte nummer");
						break;
					}
					else
					{
						campGround.smallBungalow.AddItemsToUnitList(PlaceNumber);
						for (int i = 0; i < campGround.ReservationList.Count; i++)
						{
							if (campGround.ReservationList[i].BungalowNumber == PlaceNumber && campGround.ReservationList[i].BungalowType == CampGroundReservationsInfo.BungaLowTypes.Lille)
							{
								campGround.ReservationList.RemoveAt(i); // Remove Guest from list
								toolStripStatusLabelSmallCabin.Text = string.Format("Antal ledige små hytter: {0}", campGround.smallBungalow.nofUnitsLeft);
							}
						}
					}
				}
				else if (radioBtn.Name == "radioBtnBigCabin" && radioBtnBigCabin.Checked == true)
				{
					PlaceNumber = Convert.ToInt32(numericUpDownBigCabin.Value);

					if (PlaceNumber > campGround.bigBungalow.maxUnitNumber)
					{
						ShowErrorMessage("Ugyldig hytte nummer nummer");
						break;
					}
					else
					{
						campGround.bigBungalow.AddItemsToUnitList(PlaceNumber);
						for (int i = 0; i < campGround.ReservationList.Count; i++)
						{
							if (campGround.ReservationList[i].BungalowNumber == PlaceNumber && campGround.ReservationList[i].BungalowType == CampGroundReservationsInfo.BungaLowTypes.Stor)
							{
								campGround.ReservationList.RemoveAt(i); // Remove Guest from list
								toolStripStatusLabelBigCabin.Text = string.Format("Antal ledige store hytter: {0}", campGround.bigBungalow.nofUnitsLeft);
							}
						}
					}
				}
				else if (radioBtn.Name == "radioBtnLuxuryCabin" && radioBtnLuxuryCabin.Checked == true)
					                                          
				{
					PlaceNumber = Convert.ToInt32(numericUpDownLuxuryCabin.Value);

					if (PlaceNumber > campGround.luxuryBungalow.maxUnitNumber)
					{
						ShowErrorMessage("Ugyldig hytte nummer nummer");
						break;
					}
					else
					{
						campGround.luxuryBungalow.AddItemsToUnitList(PlaceNumber);
						for (int i = 0; i < campGround.ReservationList.Count; i++)
						{
							if (campGround.ReservationList[i].BungalowNumber == PlaceNumber && campGround.ReservationList[i].BungalowType == CampGroundReservationsInfo.BungaLowTypes.Luksus)
							{
								campGround.ReservationList.RemoveAt(i); // Remove Guest from list
								toolStripStatusLabelLuxuryCabin.Text = string.Format("Antal ledige luksus hytter: {0}", campGround.luxuryBungalow.nofUnitsLeft);
							}
						}
					}
				}
			}
			CountNofPeople();
		}

		private void radioBtnSmallCabin_Click(object sender, EventArgs e)
		{
			// enable tekstfelt til små hytter
			numericUpDownSmallCabin.Enabled = true;
			// Disable tekstfelt til telt, luksus, telt 
			numericUpDownBigCabin.Enabled = false;
			numericUpDownLuxuryCabin.Enabled = false;
			numericUpDownTent.Enabled = false;
		}

		private void radioBtnTentPlace_Click(object sender, EventArgs e)
		{
			// enable tekstfelt til telt
			numericUpDownTent.Enabled = true;
			// disable tekstfelt til små, store og luksus hytter
			numericUpDownSmallCabin.Enabled = false;
			numericUpDownBigCabin.Enabled = false;
			numericUpDownLuxuryCabin.Enabled = false;
		}

		private void radioBtnBigCabin_Click(object sender, EventArgs e)
		{
			// enable tekstfelt til stor hytte
			numericUpDownBigCabin.Enabled = true;
			// disable tekstfelt til telt, lille og luksus hytte
			numericUpDownSmallCabin.Enabled = false;
			numericUpDownLuxuryCabin.Enabled = false;
			numericUpDownTent.Enabled = false;
		}

		private void radioBtnLuxuryCabin_Click(object sender, EventArgs e)
		{
			// enable tekstfelt til luksus hytte
			numericUpDownLuxuryCabin.Enabled = true;
			// Disable tekstfelt til lille og stor hytte, samt telt
			numericUpDownSmallCabin.Enabled = false;
			numericUpDownBigCabin.Enabled = false;
			numericUpDownTent.Enabled = false;

		}
	}
}
