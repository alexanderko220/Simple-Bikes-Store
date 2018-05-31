using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public class Specification
    {
        
        public int Id { get; set; }
        public string Frame { get; set; }
        public string Fork { get; set; }
        [Display(Name = "Travel Fork")]
        public string TravelFork { get; set; }
        [Display(Name = "Rear Suspension")]
        public string RearSuspension { get; set; }
        [Display(Name = "Travel Rear Suspension")]
        public string TravelRearSuspension { get; set; }
        public string Wheelset { get; set; }
        public string Brakes { get; set; }
        [Display(Name = "Brake Discs")]
        public string BrakeDiscs { get; set; }
        public string Crank { get; set; }
        [Display(Name = "Inner Bearing")]
        public string InnerBearing { get; set; }
        public string Shifter { get; set; }
        public string Derailleur { get; set; }
        [Display(Name = "Rear Derailleur")]
        public string RearDerailleur { get; set; }
        public string Cassette { get; set; }
        public string Chain { get; set; }
        [Display(Name = "Front Hub")]
        public string FrontHub { get; set; }
        [Display(Name = "Rear Hub")]
        public string RearHub { get; set; }
        public string Headset { get; set; }
        public string Grips { get; set; }
        public string Seatpost { get; set; }
        public string Saddle { get; set; }
        public string Tires { get; set; }
        public string Handlebar { get; set; }
        public string Steam { get; set; }
        public string Spokes { get; set; }
        public string Rims { get; set; }
        public string Headlight { get; set; }
        [Display(Name = "Rear Light")]
        public string RearLight { get; set; }
        [Display(Name = "Rear Rack")]
        public string RearRack { get; set; }
        public string Stand { get; set; }
        public string Splashguard { get; set; }
        public string Bell { get; set; }
        public string Color { get; set; }
        public string Weight { get; set; }
        [Display(Name = "Frame Size")]
        public string FrameSize { get; set; }
        public string Pedals { get; set; }

        public  Bike Bike { get; set; }
        public int BikeId { get; set; }
    }
}
