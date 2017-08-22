using DataLayer;
using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	public class RoomService
	{
		private ApplicationDbContext context = new ApplicationDbContext();

        /// <summary>
        /// Returns all rooms
        /// </summary>
		public List<Room> GetAllRooms()
		{
			return context.Rooms.ToList();
		}



        /// <summary>
        /// Returns all rooms form an acomodation
        /// </summary>
        /// <param name="acomodationId">The Id for an acomodation</param>
        public List<Room> GetRooms(int acomodationId)
        {
            return context.Rooms.Where(r => r.AcomodationId == acomodationId).ToList();
        }



        /// <summary>
        /// Returns all the room reservatuons
        /// </summary>
        public List<RoomReservation> GetAllRoomReservation()
        {
            return context.RoomReservations.ToList();
        }


		/// <summary>
		/// Returns a room reservation
		/// </summary>
		/// <param name="roomId">The Id of a room</param>
		/// <param name="reservationId">The Id for a reservation</param>
        public List<RoomReservation> GetRoomReservations(int roomId,int reservationId)
        {
            return context.RoomReservations.Include("Room").Where(rr => rr.RoomId == roomId && rr.ReservationId==reservationId).ToList();
        }


        /// <summary>
        /// Returns all the reservations
        /// </summary>
        public List<Reservation> GetAllReservations()
        {
            return context.Reservations.ToList();
        }



		/// <summary>
		/// Add a new room
		/// </summary>
		/// <param name="type">The type of a room</param>
		/// <param name="price">The price of a room</param>
		/// <param name="numberOdAdults">The number of adults</param>
		/// <param name="numberOfChildren">The number of children</param>
		/// <param name="photo">The photo of the room</param>
		/// <param name="description">The description of the room</param>
		/// <param name="numberOfRoomsAvailable">The number of rooms available</param>
		/// <param name="accomodationId">The Id of the acomodation </param>
		/// <returns>A new room</returns>
        public Room AddRoom(RoomType type,float price,int numberOdAdults,int numberOfChildren,string photo,string description,int numberOfRoomsAvailable,int accomodationId)
        {
            return new Room(type, price, numberOdAdults, numberOfChildren, photo, description, numberOfRoomsAvailable, accomodationId);
        }




		/// <summary>
		/// Add a new room reservation
		/// </summary>
		/// <param name="dateOfStart">The date of start</param>
		/// <param name="dateOfEnd">The date of end</param>
		/// <param name="roomId">The Id of a room</param>
		/// <param name="reservationId">The Id of a reservation</param>
		/// <returns>A new room reservation</returns>
        public RoomReservation AddRoomReservation(DateTime dateOfStart,DateTime dateOfEnd,int roomId,int reservationId)
        {
            return new RoomReservation(dateOfStart, dateOfEnd, roomId, reservationId);

        }

		private  Dictionary<string, string> _tableName;
		
public void SetTableNames()
		{
			_tableName = new Dictionary<string, string>();

			_tableName["Bond_Work_Index"] = "Bond_Work_Index";

			_tableName["Bond_Work_Index_Conversion"] = "Bond_Work_Index_Conversion";

			_tableName["Call_Factor"] = "Call_Factor";

			_tableName["Capex_spend_profile"] = "Capex_spend_profile";

			_tableName["Category_Definition"] = "Category_Definition";

			_tableName["Commodity"] = "Commodity";

			_tableName["Commodity_Payable_Rate"] = "Commodity_Payable_Rate_input";

			_tableName["Concentrate_Grade"] = "Concentrate_Grade";

			_tableName["Consumable_Supply_Accessibility"] = "Consumable_Supply_Accessibility";

			_tableName["Consumables_Consumption"] = "Consumables_Consumption_input";

			_tableName["Consumables_Efficiency_Improvement_Factor"] = "Consumables_Efficiency_Improvement_Factor_input";

			_tableName["Corp_Expl_as_Percent_of_Revenues"] = "Corp_Expl_as_Percent_of_Revenues_input";

			_tableName["Corporate_SGA_as_Percent_of_Revenues"] = "Corporate_SGA_as_Percent_of_Revenues_input";

			_tableName["Cost_Share_Fixed"] = "Cost_Share_Fixed";

			_tableName["Cost_Share_Local"] = "Cost_Share_Local";

			_tableName["Cost_Step_Groups"] = "Cost_Step_Groups";

			_tableName["Data_Quality_Score"] = "Data_Quality_Score_input";

			_tableName["Data_Quality_Score_Weight"] = "Data_Quality_Score_Weight_input";

			_tableName["Depth_of_mine"] = "Depth_Of_Mine_input";

			_tableName["Development_Stage_Score_Weight"] = "Development_Stage_Score_Weight";

			_tableName["Diesel_Efficiency_Improvement_Factor"] = "Diesel_Efficiency_Improvement_Factor_input";

			_tableName["Dilution_Factor"] = "Dilution_Factor";

			_tableName["Electricity_Selfgeneration_Type"] = "Electricity_Selfgeneration_Type";

			_tableName["Final_Transformation_Route"] = "Final_Transformation_Route_input";

			_tableName["Fraser_Institute_Score_Weight"] = "Fraser_Institute_Score_Weight";

			_tableName["Freight_Route"] = "Freight_Route_input";

			_tableName["Gravity_Mass_Pull"] = "Gravity_Mass_Pull";

			_tableName["Green_Brownfield_Score_Weight"] = "Green_Brownfield_Score_Weight";

			_tableName["Growth_Capex_Intensity"] = "Growth_Capex_Intensity_input";

			_tableName["Growth_Capex_Intensity_Price_Definition"] = "Growth_Capex_Intensity_Price_Definition";

			_tableName["InlandTransport_Ownership"] = "InlandTransport_Ownership";

			_tableName["Labour_Efficiency"] = "Labour_Efficiency_pivot";

			_tableName["Labour_Efficiency_Improvement_Factor"] = "Labour_Efficiency_Improvement_Factor_pivot";

			_tableName["LOM"] = "LOM";

			_tableName["Maintenance_capex"] = "Maintenance_capex";

			_tableName["Max_Overcap_Domestic_Market"] = "Max_Overcap_Domestic_Market_input";

			_tableName["Metallurgical_Recovery"] = "Metallurgical_Recovery";

			_tableName["Min_Max_Percent_Sustaining_Capex_vs_Opex"] = "Min_Max_Percent_Sustaining_Capex_vs_Opex";

			_tableName["Min_Seaborne_Export"] = "Min_Seaborne_Export_input";

			_tableName["MineOverhead_labour_costs_ratio"] = "MineOverhead_labour_costs_ratio";

			_tableName["MineOverhead_Management_Factor"] = "MineOverhead_Management_Factor";

			_tableName["MineOverhead_people_ratio"] = "MineOverhead_people_ratio";

			_tableName["Mining_Processing_Requirements"] = "Mining_Processing_Requirements";

			_tableName["Mining_Route"] = "Mining_Route_input";

			_tableName["Other_Cost_Routes"] = "Other_Cost_Routes_input";

			_tableName["Ownership_Score_Weight"] = "Ownership_Score_Weight";

			_tableName["Payable_Deduction"] = "Payable_Deduction_input";

			_tableName["Percent_LOM_where_MHG_matches_RG"] = "Percent_LOM_where_MHG_matches_RG";

			_tableName["Port_Ownership"] = "Port_Ownership";

			_tableName["Processing_Route"] = "Processing_Route_input";

			_tableName["Product_Definition"] = "Product_Definition";

			_tableName["Project_Timeline_Adjustments"] = "Project_Timeline_Adjustments";

			_tableName["RampDown"] = "RampDown";

			_tableName["RampUp"] = "RampUp";

			_tableName["RC"] = "RC_input";

			_tableName["Saturated_Solution_Grade"] = "Saturated_Solution_Grade";

			_tableName["Smelting_Recovery"] = "Smelting_Recovery";

			_tableName["Social_Infrastructure_Investment"] = "Social_Infrastructure_Investment";

			_tableName["Standard_Project_Timeline"] = "Standard_Project_Timeline";

			_tableName["Strip_ratio"] = "Strip_ratio_input";

			_tableName["Strip_ratio_evolution"] = "Strip_ratio_evolution_pivot";

			_tableName["Sulphuric_Acid_price_Coefficient"] = "Sulphuric_Acid_price_Coefficient";

			_tableName["Sustaining_Capex_Requirements"] = "Sustaining_Capex_Requirements";

			_tableName["TC"] = "C_input";

			_tableName["Top_down_depletion_cagr"] = "Top_down_depletion_cagr_input";

			_tableName["Top_down_forecast_cagr"] = "Top_down_forecast_cagr_input";

			_tableName["Utilization"] = "Utilization";

			_tableName["VIU_Adjustment"] = "VIU_Adjustment_input";

			_tableName["VIU_Correction_Routes"] = "VIU_Correction_Routes_input";

			_tableName["Way_Of_Transport"] = "Way_Of_Transport";

			_tableName["Working_Capital"] = "Working_Capital";

			_tableName["Years"] = "Years";

			_tableName["Base_Commodity_Demand"] = "Base_Commodity_Demand_input";

			_tableName["Base_Commodity_Demand_Std"] = "Base_Commodity_Demand_Std_input";

			_tableName["Base_Commodity_SeaborDemand_Std"] = "Base_Commodity_SeaborDemand_Std_input";

			_tableName["Base_Commodity_SeaborneDemand"] = "Base_Commodity_SeaborneDemand_input";

			_tableName["Base_Scrap_Supply"] = "Base_Scrap_Supply_input";

		}

	}
}
