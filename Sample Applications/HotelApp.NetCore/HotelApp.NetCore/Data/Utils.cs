﻿using System.ComponentModel;
using Telerik.WinControls;

namespace HotelApp.NetCore.Data
{
    public static class Utils
    {
        public static Color MainThemeColor;
        public static string MainFont = "Roboto";
        public static string MainFontMedium = "Roboto Medium";

        public static int? GetHouseKeeperIdByName(string name, BindingList<HouseKeeper> houseKeepers)
        {
            int? id = null;
            foreach (HouseKeeper hk in houseKeepers)
            {
                if (hk.Name == name)
                {
                    return hk.Id;
                }
            }
            return id;
        }

        public static string GetHouseKeepingStatus(HouseKeepingStatus houseKeepingStatus)
        {
            switch (houseKeepingStatus)
            {
                case HouseKeepingStatus.Clean:
                    return "Clean";
                case HouseKeepingStatus.NotClean:
                    return "Not clean";
                case HouseKeepingStatus.InProgress:
                    return "In progress";
                default:
                    return "N/A";
            }
        }

        public static string GetRoomType(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return "Single";
                case RoomType.Double:
                    return "Double";
                case RoomType.Triple:
                    return "Triple";//"Family (3)";
                case RoomType.Family:
                    return "Family"; //"Family (4)";
                default:
                    return "N/A";
            }
        }

        internal static System.Drawing.Image GetImageByRoomType(RoomType roomType)
        {
            switch (ThemeResolutionService.ApplicationThemeName)
            {
                case "Material":
                    return GetImageByRoomTypeMaterial(roomType);
                case "MaterialPink":
                    return GetImageByRoomTypeMaterialPink(roomType);
                case "MaterialTeal":
                    return GetImageByRoomTypeMaterialTeal(roomType);
                case "MaterialBlueGrey":
                    return GetImageByRoomTypeMaterialBlueGrey(roomType);
                default:
                    return Resource1.free_room;
            }
        }

        internal static System.Drawing.Image GetImageByRoomTypeMaterial(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return Resource1.single_user_orange;
                case RoomType.Double:
                    return Resource1.double_user_orange;
                case RoomType.Triple:
                    return Resource1.tripple_user_orange;
                case RoomType.Family:
                    return Resource1.family_user_orange;
                default:
                    return Resource1.free_room;
            }
        }

        internal static System.Drawing.Image GetImageByRoomTypeMaterialPink(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return Resource1.single_user_blue;
                case RoomType.Double:
                    return Resource1.double_user_blue;
                case RoomType.Triple:
                    return Resource1.tripple_user_blue;
                case RoomType.Family:
                    return Resource1.family_user_blue;
                default:
                    return Resource1.free_room_pink;
            }
        }

        internal static System.Drawing.Image GetImageByRoomTypeMaterialTeal(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return Resource1.single_user_red;
                case RoomType.Double:
                    return Resource1.double_user_red;
                case RoomType.Triple:
                    return Resource1.tripple_user_red;
                case RoomType.Family:
                    return Resource1.family_user_red;
                default:
                    return Resource1.free_room_teal;
            }
        }

        internal static System.Drawing.Image GetImageByRoomTypeMaterialBlueGrey(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return Resource1.single_user_green;
                case RoomType.Double:
                    return Resource1.double_user_green;
                case RoomType.Triple:
                    return Resource1.tripple_user_green;
                case RoomType.Family:
                    return Resource1.family_user_green;
                default:
                    return Resource1.free_room_bluegrey;
            }
        }

        internal static System.Drawing.Image GetRoomIconByType(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return Resource1.single_user;
                case RoomType.Double:
                    return Resource1.double_users;
                case RoomType.Triple:
                    return Resource1.tripple_users;
                case RoomType.Family:
                    return Resource1.family_users;
                default:
                    return null;
            }
        }

        internal static System.Drawing.Image GetRoomIconByHouseKeepingStatus(HouseKeepingStatus houseKeepingStatus)
        {
            switch (houseKeepingStatus)
            {
                case HouseKeepingStatus.Clean:
                    return Resource1.GlyphCheck_small;
                case HouseKeepingStatus.NotClean:
                    return Resource1.GlyphClose;
                case HouseKeepingStatus.InProgress:
                    return Resource1.clock_small;
                default:
                    return null;
            }
        }

        internal static Room GetRoomById(int roomId, BindingList<Room> rooms)
        {
            Room r = null;
            foreach (Room room in rooms)
            {
                if (room.Id == roomId)
                {
                    return room;
                }
            }
            return r;
        }

        internal static string GetRoomStatus(RoomStatus roomStatus)
        {
            switch (roomStatus)
            {
                case RoomStatus.Reserved:
                    return "Reserved";
                case RoomStatus.Occupied:
                    return "Occupied";
                case RoomStatus.Available:
                    return "Available";
                case RoomStatus.CheckedOut:
                    return "Checked-Out";
                default:
                    return "N/A";
            }
        }

        internal static System.Drawing.Image GetRoomImageByRoomType(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return Resource1.single;
                case RoomType.Double:
                    return Resource1._double;
                case RoomType.Triple:
                    return Resource1.tripple;
                case RoomType.Family:
                    return Resource1.family;
                default:
                    return null;
            }
        }

        public static string GetBookingTypeByStatus(BookingStatus bk)
        {
            switch (bk)
            {
                case BookingStatus.Reservation:
                    return "Reservation";
                case BookingStatus.Actual:
                    return "Actual";
                case BookingStatus.Cancelled:
                    return "Cancelled";
                case BookingStatus.CheckedOut:
                    return "Checked out";
                case BookingStatus.NoShow:
                    return "No-show";
                default:
                    return "N/A";
            }
        }

        public static Guest GetGuestById(BindingList<Guest> guests, string id)
        {
            Guest g = null;
            foreach (Guest guest in guests)
            {
                if (guest.Id == id)
                {
                    return guest;
                }
            }
            return g;
        }

        internal static Image GetAvailableImageByTheme()
        {
            switch (ThemeResolutionService.ApplicationThemeName)
            {
                case "Material":
                    return Resource1.free_room;
                case "MaterialPink":
                    return Resource1.free_room_pink;
                case "MaterialTeal":
                    return Resource1.free_room_teal;
                case "MaterialBlueGrey":
                    return Resource1.free_room_bluegrey;
                default:
                    return Resource1.free_room;
            }
        }
    }
}