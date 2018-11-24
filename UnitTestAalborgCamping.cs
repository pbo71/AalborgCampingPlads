using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsAalborgCamping;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTestAalborgCamping
	{

		[TestMethod]
		public void TestMethodTentPlaces()
		{
			CampGround campingPlace = new CampGround(10,0,0,0);
			Assert.AreEqual(10, campingPlace.pitch.nofUnitsLeft);
			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(1), "Add tent place no.1");
			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(2), "Add tent place no.2");
			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(3), "Add tent place no.3");
			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(4), "Add tent place no.4");
			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(5), "Add tent place no.5");

			Assert.IsFalse(campingPlace.pitch.RemoveItemsFromUnitList(5), "Add tent place no.5 again");

			Assert.AreEqual(5, campingPlace.pitch.nofUnitsLeft);

			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(6), "Add tent place no.6");
			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(7), "Add tent place no.7");
			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(8), "Add tent place no.8");
			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(9), "Add tent place no.9");
			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(10), "Add tent place no.10");

			Assert.AreEqual(0, campingPlace.pitch.nofUnitsLeft);

			campingPlace.pitch.AddItemsToUnitList(5);
			
			Assert.AreEqual(1, campingPlace.pitch.nofUnitsLeft);

			Assert.IsTrue(campingPlace.pitch.RemoveItemsFromUnitList(5), "Add tent place 5 after free it");

			Assert.AreEqual(0, campingPlace.pitch.nofUnitsLeft);

		}

		[TestMethod]
		public void TestMethodSmallCabin()
		{
			CampGround campingPlace = new CampGround(0, 8, 0, 0);
			Assert.AreEqual(8,campingPlace.smallBungalow.nofUnitsLeft);

			Assert.IsTrue(campingPlace.smallBungalow.RemoveItemsFromUnitList(1), "Add small cabin no.1");
			Assert.IsTrue(campingPlace.smallBungalow.RemoveItemsFromUnitList(2), "Add small cabin no.2");
			Assert.IsTrue(campingPlace.smallBungalow.RemoveItemsFromUnitList(3), "Add small cabin no.3");
			Assert.IsTrue(campingPlace.smallBungalow.RemoveItemsFromUnitList(4), "Add small cabin no.4");
			Assert.IsTrue(campingPlace.smallBungalow.RemoveItemsFromUnitList(5), "Add small cabin no.5");

			Assert.AreEqual(3, campingPlace.smallBungalow.nofUnitsLeft, "expect 3 left");

			Assert.IsTrue(campingPlace.smallBungalow.RemoveItemsFromUnitList(6), "Add small cabin no.6");
			Assert.IsFalse(campingPlace.smallBungalow.RemoveItemsFromUnitList(6), "Add small cabin no.6 again");

			Assert.IsTrue(campingPlace.smallBungalow.RemoveItemsFromUnitList(7), "Add small cabin no.7");
			Assert.IsTrue(campingPlace.smallBungalow.RemoveItemsFromUnitList(8), "Add small cabin no.8");

			Assert.IsFalse(campingPlace.smallBungalow.RemoveItemsFromUnitList(9), "Add small cabin no.9");

			Assert.AreEqual(0, campingPlace.smallBungalow.nofUnitsLeft, "expect 0 left");

			campingPlace.smallBungalow.AddItemsToUnitList(5);

			Assert.AreEqual(1, campingPlace.smallBungalow.nofUnitsLeft, "expect 0 left");

		}

		[TestMethod]
		public void TestMethodBigCabin()
		{
			CampGround campingPlace = new CampGround(0, 0, 5, 0);
			Assert.AreEqual(5, campingPlace.bigBungalow.nofUnitsLeft);
			Assert.IsTrue(campingPlace.bigBungalow.RemoveItemsFromUnitList(1), "Add big cabin no.1");
			Assert.IsTrue(campingPlace.bigBungalow.RemoveItemsFromUnitList(2), "Add big cabin no.2");
			Assert.IsTrue(campingPlace.bigBungalow.RemoveItemsFromUnitList(3), "Add big cabin no.3");
			Assert.AreEqual(2, campingPlace.bigBungalow.nofUnitsLeft);
			Assert.IsTrue(campingPlace.bigBungalow.RemoveItemsFromUnitList(4), "Add big cabin no.4");
			Assert.IsTrue(campingPlace.bigBungalow.RemoveItemsFromUnitList(5), "Add big cabin no.5");
			Assert.IsFalse(campingPlace.bigBungalow.RemoveItemsFromUnitList(5), "Add big cabin no.5 again");
			campingPlace.bigBungalow.AddItemsToUnitList(3);
			Assert.AreEqual(1, campingPlace.bigBungalow.nofUnitsLeft);

		}
		[TestMethod]
		public void TestMethodLuxuryCabin()
		{
			CampGround campingPlace = new CampGround(0, 0, 0, 2);
			Assert.AreEqual(2, campingPlace.luxuryBungalow.nofUnitsLeft);
			Assert.IsTrue(campingPlace.luxuryBungalow.RemoveItemsFromUnitList(1), "Add big cabin no.1");
			Assert.IsTrue(campingPlace.luxuryBungalow.RemoveItemsFromUnitList(2), "Add big cabin no.2");
			Assert.AreEqual(0, campingPlace.luxuryBungalow.nofUnitsLeft);
			Assert.IsFalse(campingPlace.luxuryBungalow.RemoveItemsFromUnitList(2), "Add big cabin no.2 again");
			campingPlace.luxuryBungalow.AddItemsToUnitList(2);
			Assert.AreEqual(1, campingPlace.luxuryBungalow.nofUnitsLeft);
		}

		[TestMethod]
		public void TestGuest()
		{
			CampGroundReservationsInfo guest = new CampGroundReservationsInfo();

			guest.Name = "Unit Test";
			guest.Adults = 1;
			guest.Animal = false;
			guest.Kids = 2;
			guest.BungalowNumber = 1;
			guest.BungalowType = CampGroundReservationsInfo.BungaLowTypes.Lille;
			guest.SiteNumber = 100;


			Assert.AreEqual("Unit Test", guest.Name);
			Assert.AreEqual(1, guest.Adults);
			Assert.AreEqual(2, guest.Kids);
			Assert.AreEqual(false, guest.Animal);

			Assert.AreEqual(1, guest.BungalowNumber);
			Assert.AreEqual(CampGroundReservationsInfo.BungaLowTypes.Lille, guest.BungalowType);
			Assert.AreEqual(100, guest.SiteNumber);

		}

		[TestMethod]
		public void TestAddItemToUnitList()
		{
			CampGround campingPlace = new CampGround(5, 0, 0, 0);
			campingPlace.pitch.AddItemsToUnitList(1);
			Assert.AreEqual(5, campingPlace.pitch.nofUnitsLeft);
			campingPlace.pitch.RemoveItemsFromUnitList(1);
			Assert.AreEqual(4, campingPlace.pitch.nofUnitsLeft);
			campingPlace.pitch.AddItemsToUnitList(1);
			campingPlace.pitch.AddItemsToUnitList(1);
			campingPlace.pitch.AddItemsToUnitList(2);
			Assert.AreEqual(5, campingPlace.pitch.nofUnitsLeft);
		}
	}
}
