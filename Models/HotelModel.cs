using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelsBooking.Models
{
    public class OfferInfo
    {
        public string siteID { get; set; }
        public string language { get; set; }
        public string currency { get; set; }
        public string userSelectedCurrency { get; set; }
    }

    public class Persona
    {
        public string personaType { get; set; }
    }

    public class UserInfo
    {
        public Persona persona { get; set; }
        public string userId { get; set; }
    }

    public class OfferDateRange
    {
        public List<int> travelStartDate { get; set; }
        public List<int> travelEndDate { get; set; }
        public int lengthOfStay { get; set; }
    }

    public class Destination
    {
        public string regionID { get; set; }
        public string associatedMultiCityRegionId { get; set; }
        public string longName { get; set; }
        public string shortName { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string tla { get; set; }
        public string nonLocalizedCity { get; set; }
    }

    public class HotelInfo
    {
        public string hotelId { get; set; }
        public string hotelName { get; set; }
        public string localizedHotelName { get; set; }
        public string hotelDestination { get; set; }
        public string hotelDestinationRegionID { get; set; }
        public string hotelLongDestination { get; set; }
        public string hotelStreetAddress { get; set; }
        public string hotelCity { get; set; }
        public string hotelProvince { get; set; }
        public string hotelCountryCode { get; set; }
        public double hotelLatitude { get; set; }
        public double hotelLongitude { get; set; }
        public string hotelStarRating { get; set; }
        public double hotelGuestReviewRating { get; set; }
        public int hotelReviewTotal { get; set; }
        public string hotelImageUrl { get; set; }
        public bool isOfficialRating { get; set; }
    }

    public class HotelUrgencyInfo
    {
        public int airAttachRemainingTime { get; set; }
        public int numberOfPeopleViewing { get; set; }
        public int numberOfPeopleBooked { get; set; }
        public int numberOfRoomsLeft { get; set; }
        public object lastBookedTime { get; set; }
        public string almostSoldStatus { get; set; }
        public string link { get; set; }
        public bool airAttachEnabled { get; set; }
    }

    public class HotelPricingInfo
    {
        public double averagePriceValue { get; set; }
        public double totalPriceValue { get; set; }
        public double crossOutPriceValue { get; set; }
        public double originalPricePerNight { get; set; }
        public string currency { get; set; }
        public double percentSavings { get; set; }
        public bool drr { get; set; }
    }

    public class HotelUrls
    {
        public string hotelInfositeUrl { get; set; }
        public string hotelSearchResultUrl { get; set; }
    }

    public class HotelModel
    {
        public OfferDateRange offerDateRange { get; set; }
        public Destination destination { get; set; }
        public HotelInfo hotelInfo { get; set; }
        public HotelUrgencyInfo hotelUrgencyInfo { get; set; }
        public HotelPricingInfo hotelPricingInfo { get; set; }
        public HotelUrls hotelUrls { get; set; }

    }
    public class HotelViewModel
    {
        public List<HotelModel> HotelsList { get; set; }
        public string SelectedCountry { get; set; }
        public string hdnCountry { get; set; }
        public string hdnCity { get; set; }
        public string hdnPlace_id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? DateFrom { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? DateTo { get; set; }
        public int? LengthOfStay { get; set; }
        public decimal? MaxStarRating { get; set; }
        public decimal? MinStarRating { get; set; }

        public int? MaxTotalRate { get; set; }
        public int? MinTotalRate { get; set; }
        public decimal? MaxGuestRating { get; set; }
        public decimal? MinGuestRating { get; set; }




    }

    public class Offers
    {
        public List<HotelModel> Hotel { get; set; }
    }

    public class RootObject
    {
        public OfferInfo offerInfo { get; set; }
        public UserInfo userInfo { get; set; }
        public Offers offers { get; set; }
    }
}