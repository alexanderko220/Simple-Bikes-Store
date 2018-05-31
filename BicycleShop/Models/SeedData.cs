using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleShop.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Bikes.Any())
            {
                context.Bikes.AddRange(
                    //ROAD
                    new Bike { Model = "R1 105 2018", Price = 999m, Category = Categories["ROAD"], Specifications =
                    new Specification {
                        Frame = "R1",
                        Fork = "Radon R1 Full Carbon",
                        Wheelset = "Mavic Aksium RS",
                        Brakes = "Shimano 105 BR-5800",
                        Crank = @"Shimano FC-RS510, 50x34T, 170/172.5/172.5/175/175/175 mm",
                        InnerBearing = "Shimano BB-RS500, Pressfit",
                        Shifter = "Shimano 105 ST-5800, 11-speed",
                        Derailleur = "Shimano 105 FD-5800-BLL, 34.9mm",
                        RearDerailleur = "Shimano 105 RD-5800GS",
                        Cassette = "Shimano 105 CS-5800, 11-32",
                        Chain = "Shimano CN-HG601",
                        Seatpost = "LEVEL NINE Race, 31.6 x 350 mm",
                        Saddle = "Selle Italia SL MG",
                        Tires = "Continental Ultra Sport 2, 28\" x 25mm",
                        Color = "deep black / shining yellow",
                        Weight = "8,60 kg*",
                        Headset = "R1 Series Special, IS41/IS46",
                        Grips = "Radon tape",
                        FrameSize = "50cm, 53cm, 56cm, 58cm, 60cm, 63cm",
                        Pedals = "not included",
                        Handlebar = "LEVEL NINE Wing Race, 31.8mm x 40/42/44/44/46/46 cm",
                        Steam = "LEVEL NINE Race, 31.8 x 90/90/100/100/120/120 mm"
                    },
                        ShortDescription = "Road Bike",
                        LongDescription = "The Shimano 105 gears stand for high quality and precision at an affordable price. Reliable and low drag Mavic Aksium RS wheels shine with sleek aero spokes. Unnecessary weight is saved with the aerodynamic Radon R1 carbon fork and lightweight LEVEL NINE components. The smooth-rolling Continental Ultra Sport II tyres ensure your training runs are always fun.",
                        InStock = true,
                        ImageUrl = "/Content/Images/bikes/road_R1_105_2018.jpg",
                        ImageThumbnailUrl = "/Content/Images/bikes/road_IGNITE_105_Thumbnail.jpg",
                        IsBikeOfTheWeek = true
                        
                    },

                    new Bike
                    {
                        Model = "IGNITE 105",
                        Price = 999m,
                        Category = Categories["ROAD"],
                        Specifications =
                    new Specification
                    {
                        Frame = "IGNITE",
                        Fork = "Radon Ignite Full Carbon",
                        Wheelset = "DT Swiss R24 Spline",
                        Brakes = "Shimano 105 BR-5800",
                        Crank = "Shimano 105 FC-5800, 50x34T, 172.5/172.5/175/175/175 mm",
                        InnerBearing = "Shimano BB-RS500, Pressfit",
                        Shifter = "Shimano 105 ST-5800, 11-speed",
                        Derailleur = "Shimano 105 FD-5800-BL, 31.8mm",
                        RearDerailleur = "Shimano 105 RD-5800SS",
                        Cassette = "Shimano 105 CS-5800, 11-28",
                        Chain = "Shimano CN-HG601",
                        Seatpost = "RFR lite, 27.2 x 350 mm",
                        Saddle = "Selle Italia SL",
                        Tires = "Schwalbe One, PerL, Kevlar, 25mm",
                        Color = "deep black / stealth grey / bright red",
                        Weight = "7,90 kg*",
                        Headset = "R1 Series Special, IS41/IS46",
                        Grips = "Radon tape",
                        FrameSize = "53cm, 56cm, 58cm, 60cm, 63cm",
                        Pedals = "not included",
                        Handlebar = "Syntace Racelite CDR, 31.8mm x 42/44/44/46/46 cm",
                        Steam = "Syntace F149, 31.8 x 90/100/100/120/120 mm"
                    },
                        ShortDescription = "Road Bike",
                        LongDescription = "A fair racer – with a sturdy aluminium frame and tried and tested components: we use the legendary 105 groupset for 2x11-speed drivetrain and brakes on the IGNITE COMFORT 105. The bike has full carbon forks, lightweight DT Swiss R24 Spline wheels and speedy Schwalbe One tyres with Kevlar® fibres, and high-quality Syntace components. A great, lightweight full package for just €1299.",
                        InStock = true,
                        ImageUrl = "/Content/Images/bikes/road_IGNITE_105.jpg",
                        ImageThumbnailUrl = "/Content/Images/bikes//road_IGNITE_105_Thumbnail.jpg",
                        IsBikeOfTheWeek = true

                    },

                    new Bike
                    {
                        Model = "SAGE CARBON ULTEGRA 2018",
                        Price = 1699m,
                        Category = Categories["ROAD"],
                        Specifications =
                    new Specification
                    {
                        Frame = "SAGE Carbon",
                        Fork = "RADON SAGE Full Carbon",
                        Wheelset = "Mavic Aksium Elite",
                        Brakes = "Shimano Ultegra BR-8000",
                        Crank = "Shimano Ultegra FC-R8000, 50x34T, 172.5/172.5/175/175/175 mm",
                        InnerBearing = "Shimano BB-RS500, Pressfit",
                        Shifter = "Shimano Ultegra ST-R8000, 11-speed",
                        Derailleur = "Shimano Ultegra FD-R8000BL, 34.9mm",
                        RearDerailleur = "Shimano Ultegra RD-R8000GS",
                        Cassette = "Shimano 105 CS-5800, 11-32",
                        Chain = "Shimano CN-HG601",
                        Seatpost = "LEVEL NINE Race, 27.2 x 350 mm",
                        Saddle = "Selle Italia SL MG",
                        Tires = "Schwalbe Pro One, Kevlar, 28\" x 23mm",
                        Color = "UD-deep black / bright red / stealth grey",
                        Weight = "7,75 kg*",
                        Headset = "SAGE Series Special, IS41/IS52",
                        Grips = "Radon tape",
                        FrameSize = "50cm, 53cm, 56cm, 58cm, 60cm, 63cm",
                        Pedals = "not included",
                        Handlebar = "LEVEL NINE Wing Race, 31.8 x 42/44/44/46/46 cm",
                        Steam = "LEVEL NINE Race, 31.8 x 90/100/100/120/120 mm"
                    },
                        ShortDescription = "Road Bike",
                        LongDescription = "Precision Shimano Ultegra gears, stable Mavic Aksium wheels with sleek aero spokes and smooth-rolling Schwalbe Pro One tyres give you a package ideal to beat opponents and training buddies in sprint duels. After you've blown them away, airflow becomes your new best friend: SAGE CARBON streamlined forks and low lying LEVEL NINE handlebars for an aerodynamic sitting position and minimal turbulence at high speeds.",
                        InStock = true,
                        ImageUrl = "/Content/Images/bikes/road_SAGE_CARBON_ULTEGRA_2018.jpg",
                        ImageThumbnailUrl = "/Content/Images/bikes/road_SAGE_CARBON_ULTEGRA_2018_Thumbnail.jpg",
                        IsBikeOfTheWeek = false

                    },
                    
                    new Bike
                    {
                        Model = "VAILLANT CARBON ULTEGRA",
                        Price = 1799m,
                        Category = Categories["ROAD"],
                        Specifications =
                    new Specification
                    {
                        Frame = "VAILLANT",
                        Fork = "VAILLANT Carbon",
                        Wheelset = "Mavic Cosmic Elite",
                        Brakes = "Shimano Ultegra BR-6800",
                        Crank = "Shimano Ultegra FC-6800, 50x34T, 172.5/172.5/175/175/175 m",
                        InnerBearing = "Shimano BB-RS500, Pressfit",
                        Shifter = "Shimano Ultegra ST-6800, 11-speed",
                        Derailleur = "Shimano Ultegra FD-6800",
                        RearDerailleur = "Shimano Ultegra RD-6800SS",
                        Cassette = "Shimano Ultegra CS-6800, 11-28",
                        Chain = "Shimano CN-HG601",
                        Seatpost = "RADON VAILLANT Singlehead",
                        Saddle = "Selle Italia SLR MG",
                        Tires = "Continental GP4000s, Kevlar, 25mm",
                        Color = "deep black / powder white glossy",
                        Weight = "7,40 kg*",
                        Headset = "VAILLANT Series Special, IS41/IS46",
                        Grips = "Radon tape",
                        FrameSize = "XS, S, M, L, XL",
                        Pedals = "not included",
                        Handlebar = "Syntace Racelite CDR, 31.8 x 42/44/44/46/46 cm",
                        Steam = "Syntace F149, 31.8 x 90/100/100/120/120 mm"
                    },
                        ShortDescription = "Road Bike",
                        LongDescription = "Our aero racer uses the full Shimano Ultegra gear and brake groupsets – equipment that has proved itself many times over on the professional tour circuit. Every part has been optimised for perfect ergonomics and energy-saving operation to counter the signs of tiredness even on longer tours. The carbon racer uses Mavic Cosmic Elite wheels. Classy Syntace components offer big reserves of stability and ensure a highly safe steering.",
                        InStock = true,
                        ImageUrl = "/Content/Images/bikes/road_VAILLANT_CARBON_ULTEGRA.jpg",
                        ImageThumbnailUrl = "/Content/Images/bikes/road_VAILLANT_CARBON_ULTEGRA_Thumbnail.jpg",
                        IsBikeOfTheWeek = false
                    },

                    //CROSS / TREKKING
                    new Bike
                    {
                        Model = "SCART 6.0 2018",
                        Price = 599m,
                        Category = Categories["CROSS & TREKKING"],
                        Specifications =
                    new Specification
                    {
                        Frame = "SCART",
                        Fork = "Suntour NEX, HLO",
                        TravelFork = "63mm",
                        Wheelset = "Mavic Cosmic Elite",
                        Brakes = "Shimano BR-M315",
                        BrakeDiscs = "Shimano SM-RT10 180/160mm, center-lock",
                        Crank = "Shimano Alivio FC-T4010, 48x36x26T, 175mm",
                        InnerBearing = "Shimano BB-ES300, 68mm BSA",
                        Shifter = "Shimano Acera SL-M3000, 9-speed",
                        Derailleur = "Shimano Acera FD-T3000, Topswing, 34.9mm",
                        RearDerailleur = "Shimano Acera RD-M3000-SGS",
                        Cassette = "Shimano CS-HG200, 11-34",
                        Chain = "Shimano CN-HG53",
                        FrontHub = "Shimano Deore FH-T610",
                        RearHub = "Shimano Deore HB-T610",
                        Spokes = "DT Swiss",
                        Rims = "Alex EN24",
                        Seatpost = "LEVEL NINE Race 30.9 x 350 mm",
                        Saddle = "Selle Italia X1",
                        Tires = "Schwalbe G-One, PerfL, Kevlar, 28\" x 35mm",
                        Color = "deep black / stealth grey / sea green",
                        Weight = "13,30 kg*",
                        Headset = "FSA, ZS44/ZS56",
                        Grips = "Ergon GE10 slim",
                        FrameSize = "48cm, 52cm, 56cm, 60cm, 64cm",
                        Pedals = "not included",
                        Handlebar = "LEVEL NINE Race, 31.8 x 660 mm",
                        Steam = "LEVEL NINE Race, 31.8 x 90/100/100/110/120 mm"
                    },
                        ShortDescription = "Cross/Trekking for dirt tracks, forest roads and paved trails.",
                        LongDescription = "A low-cost entry into the cross-world with Suntour suspension forks with lockout, reliable Shimano hydraulic brakes and groupset. The Schwalbe G-One with grippy side tread for off-tarmac riding fun. And comfort isn’t neglected when venturing into the woods with the Ergon GE10 grips and Selle Italia X1 saddle.",
                        InStock = true,
                        ImageUrl = "/Content/Images/bikes/cross_SCART 6.0 2018.jpg",
                        ImageThumbnailUrl = "/Content/Images/bikes/road_SCART 6.0 2018_Thumbnail.jpg",
                        IsBikeOfTheWeek = true
                    },

                    new Bike
                    {
                        Model = "SOLUTION COMFORT 5.0",
                        Price = 599m,
                        Category = Categories["CROSS & TREKKING"],
                        Specifications =
                    new Specification
                    {
                        Frame = "SOLUTION COMFORT",
                        Fork = "Suntour NEX",
                        TravelFork = "63mm",
                        Brakes = "Shimano BR-M315",
                        BrakeDiscs = "Shimano RT10, 160/160mm, center-lock",
                        Crank = "Shimano Tourney FC-TX801, 48x38x28T, 175mm",
                        InnerBearing = "Shimano BB-UN100, 123mm (68mm BSA)",
                        Shifter = "Shimano Altus SL-M310, 8-speed",
                        Derailleur = "Shimano Altus FD-M310, Topswing, 34.9mm",
                        RearDerailleur = "Shimano Acera RD-M360-SGS",
                        Cassette = "Shimano CS-HG31, 11-34",
                        Chain = "Shimano CN-HG40",
                        FrontHub = "Shimano Dynamo DH-3D37",
                        RearHub = "Shimano Tourney FH-TX505",
                        Spokes = "DT Swiss",
                        Rims = "Alex EN24",
                        Handlebar = "LEVEL NINE Race, 31.8 x 660 mm",
                        Steam = "Swell-R Eco adjust, 31.8 x 100/100/120/120/120 mm",
                        Headset = "FSA, ZS44/ZS56",
                        Grips = "Ergon GP10 L",
                        Seatpost = "LEVEL NINE Race 30.9 x 350 mm",
                        Saddle = "Selle Royal Freccia",
                        Tires = "Schwalbe Road Cruiser, ActiveL, 28\" x 42mm",
                        Headlight = "B&M LYT 1781, 20 Lux",
                        RearLight = "B&M Toplight Flat plus",
                        RearRack = "Racktime Light-it",
                        Stand = "Pletscher Comp 40 Flex",
                        Bell = "Radon Mini Bell",
                        Splashguard = "SKS Bluemels Radon Plus Edition 45",
                        Color = "deep black / stealth grey / powder white",
                        Weight = "16,15 kg*",             
                        FrameSize = "48cm, 52cm, 56cm, 60cm, 64cm",
                        Pedals = "not included"
                        
                        
                    },
                        ShortDescription = "Cross/Trekking for dirt tracks, forest roads and paved trails.",
                        LongDescription = "Practical, comfortable and top value for money. While the Suntour NEX suspension forks provide a comfortable ride even on bad roads, a Racktime carrier system makes the SOLUTION COMFORT 5.0 a genuine everyday star. A Busch + Müller light system enables you to turn night into day and a hub dynamo provides safe riding at all times. And where safety’s concerned, hydraulic Shimano disc brakes gives you stopping power in any situation. Also, with 24 gears you have a good range for tours in the low mountain range.",
                        InStock = true,
                        ImageUrl = "/Content/Images/bikes/cross_SOLUTION COMFORT 5.0.jpg",
                        ImageThumbnailUrl = "/Content/Images/bikes/cross_SOLUTION COMFORT 5.0_Thumbnail.jpg",
                        IsBikeOfTheWeek = false
                    },

                    //TOUR / CROSS COUNTRY
                    new Bike
                     {
                         Model = "ZR TEAM 27.5 7.0 2018",
                         Price = 849m,
                         Category = Categories["CROSS COUNTRY"],
                         Specifications =
                    new Specification
                    {
                        Frame = "ZR TEAM 27,5",
                        Fork = "Rock Shox Judy Silver, Boost, TK, R, SA",
                        TravelFork = "100mm",
                        Brakes = "Shimano BR-M315",
                        BrakeDiscs = "Shimano SM-RT10 180/160mm, center-lock",
                        Crank = "Shimano FC-MT500, 40x30x22, 175mm",
                        InnerBearing = "Shimano Deore SM-BB52, 73mm BSA",
                        Shifter = "Shimano Deore SL-M6000, 10-speed",
                        Derailleur = "Shimano Deore FD-M610, topswing, 34.9mm",
                        RearDerailleur = "Shimano XT RD-M781-SGS",
                        Cassette = "Shimano CS-HG50, 11-36",
                        Chain = "Shimano CN-HG54",
                        FrontHub = "Shimano Deore HB-M6010, Boost",
                        RearHub = "Shimano Deore HB-M6000",
                        Spokes = "DT Swiss Factory",
                        Rims = "ALEX SD 20",
                        Handlebar = "LEVEL NINE Race, 31.8 x 720 mm, 15mm rise",
                        Steam = "LEVEL NINE Race, 31.8mm, 6°, 60/75/75 mm",
                        Headset = "FSA, ZS44/ZS56",
                        Grips = "RADON performance grips",
                        Seatpost = "LEVEL NINE Race 30.9 x 400 mm",
                        Saddle = "Selle Italia X1",
                        Tires = "Schwalbe Nobby Nic, Addix PerfL, 27.5 x 2.25",
                        Color = "deep black / deep black glossy / lime green",
                        Weight = "12,60 kg*",
                        FrameSize = "16\",18\", 20\"",
                        Pedals = "not included"


                    },
                         ShortDescription = "For all XC fans who frequently ride on unpaved surfaces and aren’t afraid of roots, stones or small drops, we recommend our models from the “Tour/Cross Country” category.",
                         LongDescription = "The brand-new and responsive JUDY forks in boost format from Rock Shox, and the proven cross country classic Schwalbe Nobby Nic give you a sporty set-up for fast off-road tours. Combined with Shimano's precision XT rear derailleur and the comfortable Selle Italia X1 saddle, you get performance and comfort on longer rides. Grippy Shimano hydraulic brakes with 180mm and 160mm discs complete an all-round carefree package. Size Split gives you options: top manoeuvrability in turns thanks to 27.5 inch or, when the going gets tough, maximum smoothness with 29 inch wheels!",
                         InStock = true,
                         ImageUrl = "/Content/Images/bikes/cross_ZR TEAM 27.5 7.0 2018.jpg",
                         ImageThumbnailUrl = "/Content/Images/bikes/cross_ZR TEAM 27.5 7.0 2018_Thumbnail.jpg",
                         IsBikeOfTheWeek = false
                     },

                    new Bike
                     {
                         Model = "JEALOUS 8.0 2018",
                         Price = 2999m,
                         Category = Categories["CROSS COUNTRY"],
                         Specifications =
                    new Specification
                    {
                        Frame = "JEALOUS CF",
                        Fork = "Rock Shox SID, RL, R, SA, Boost",
                        TravelFork = "100mm",
                        Wheelset = "Newmen Evolution SL X.A.25, 110/148",
                        Brakes = "Magura MT Trail Custom",
                        BrakeDiscs = "Magura Storm HC 180/160",
                        Crank = "SRAM X1 Eagle Carbon, Boost, 34T, 175mm",
                        InnerBearing = "SRAM GXP, Pressfit 92",
                        Shifter = "SRAM GX Eagle, 12-speed, Shiftmix",
                        RearDerailleur = "SRAM GX Eagle",
                        Cassette = "SRAM XG-1275, 10-50",
                        Chain = "SRAM GX Eagle",
                        Handlebar = "Newmen Advanced, 31.8 x 740 mm",
                        Steam = "Newmen Evolution SL, 31.8mm, 4s, 60/70/70/80 mm",
                        Headset = "Acros AiX, IS41/IS52",
                        Grips = "RADON racing grips",
                        Seatpost = "Newmen Advanced Carbon, 30.9 x 430 mm",
                        Saddle = "Selle Italia SLR MG",
                        Tires = "Schwalbe Rocket Ron, Addix-Speed, LS, Kevlar, 29 x 2.25",
                        Color = "UD-deep black / light blue / bright petrol / powder white",
                        Weight = "9,05 kg*",
                        FrameSize = "16\",18\", 20\" 22\"",
                        Pedals = "not included"


                    },
                         ShortDescription = "For all XC fans who frequently ride on unpaved surfaces and aren’t afraid of roots, stones or small drops, we recommend our models from the “Tour/Cross Country” category.",
                         LongDescription = "With the SRAM GX Eagle Group, you’ll enjoy a precision 1x12 drivetrain without it costing you a fortune. Lightweight Newmen wheels give you loads of durability and precision when taking an aggressive line. Are you into lightweight construction? Carbon parts from Newmen rids with every unnecessary gram without compromising stability.",
                         InStock = true,
                         ImageUrl = "/Content/Images/bikes/cross_JEALOUS 8.0 2018.jpg",
                         ImageThumbnailUrl = "/Content/Images/bikes/cross_JEALOUS 8.0 2018_Thumbnail.jpg",
                         IsBikeOfTheWeek = false
                     },

                     //ALL MOUNTAIN / ENDURO
                    new Bike
                     {
                         Model = "SKEEN TRAIL 27.5 8.0 2018",
                         Price = 1999m,
                         Category = Categories["MOUNTAIN"],
                         Specifications =
                    new Specification
                    {
                        Frame = "SKEEN TRAIL 27.5",
                        Fork = "Rock Shox Reba, RL, R, Boost",
                        RearSuspension = "Rock Shox Monarch, RT3, HVI, 184x44",
                        TravelFork = "100mm",
                        TravelRearSuspension = "120mm",
                        Wheelset = "Mavic Crossride, 110/142",
                        Brakes = "Magura MT Trail Custom",
                        BrakeDiscs = "Magura Storm HC 180/180mm, 6-bolt",
                        Crank = "Shimano SLX FC-M7000-2, 36x26, 175mm",
                        InnerBearing = "Shimano BB-MT500PA, Pressfit",
                        Shifter = "Shimano XT SL-M8000-I, 11-speed, I-Spec",
                        Derailleur = "Shimano SLX FD-M7020,direct mount, sideswing",
                        RearDerailleur = "Shimano XT RD-M8000-SGS",
                        Cassette = "Shimano SLX CS-M7000, 11-42",
                        Chain = "Shimano CN-HG601",
                        Handlebar = "LEVEL NINE Race, 31.8 x 740 mm",
                        Steam = "LEVEL NINE Race, 31.8mm, 60/60/75 mm",
                        Headset = "FSA, ZS44/IS52",
                        Grips = "Ergon GE10 slim",
                        Seatpost = "LEVEL NINE Race, 30.9 x 400 mm",
                        Saddle = "Selle Italia X1",
                        Tires = "Schwalbe Nobby Nic, Addix-PerfL, Kevlar, 27.5 x 2.35",
                        Color = "deep black / stealth grey / shining yellow",
                        Weight = "12,45 kg*",
                        FrameSize = "16\",18\", 20\"",
                        Pedals = "not included"


                    },
                         ShortDescription = "Whether it’s a flowing trail or rough and technical section – with a bike from the “All Mountain/Enduro” category, you’re ready for anything!",
                         LongDescription = "The SKEEN TRAIL 8.0 is the perfect introduction to single-trail fun: a high-quality Shimano XT rear derailleur for fast shifting on the trail and smooth suspension consisting of Rock Shox Reba forks and Monarch dampers that smooth out even the subtlest of shocks to guarantee flow. The Magura MT Trail brings you back to reality with a smile when you lose sense of speed. Size Split gives you the choice. Do you want manoeuvrability in turns with 27.5 inch wheels, or smooth riding over tree roots and rocks with 29 inch wheels?",
                         InStock = true,
                         ImageUrl = "/Content/Images/bikes/mount_SKEEN TRAIL 27.5 8.0 2018.jpg",
                         ImageThumbnailUrl = "/Content/Images/bikes/mount_SKEEN TRAIL 27.5 8.0 2018_Thumbnail.jpg",
                         IsBikeOfTheWeek = true
                     },


                    new Bike
                     {
                         Model = "JAB 9.0 HD",
                         Price = 4199m,
                         Category = Categories["MOUNTAIN"],
                         Specifications =
                    new Specification
                    {
                        Frame = "JAB",
                        Fork = "Rock Shox Lyrik, RCT3, Boost",
                        RearSuspension = "Rock Shox Super Deluxe RC3, Debon Air, Trunnion Mount, 205x65",
                        TravelFork = "160mm",
                        TravelRearSuspension = "160mm",
                        Wheelset = "e*thirteen TRS, Boost 110/148",
                        Brakes = "SRAM Code R",
                        BrakeDiscs = "SRAM Elixir Centerline 200/180mm, 6-bolt",
                        Crank = "SRAM Descendant Eagle Carbon, 32T, 170mm",
                        InnerBearing = "SRAM GXP, Pressfit 92",
                        Shifter = "SRAM X01 Eagle, 12-speed, Matchmaker X",
                        RearDerailleur = "SRAM X01 Eagle",
                        Cassette = "SRAM XG-1275, 10-50",
                        Chain = "SRAM PC-X01",
                        Handlebar = "Race Face Turbine R, 35 x 780 mm, 20mm rise",
                        Steam = "Race Face Turbine R, 35 x 40/40/40 mm",
                        Headset = "Acros AZX, ZS44/ZS56",
                        Grips = "SDG Slater",
                        Seatpost = "SDG Dropper, 31.6 x 125/150/150 mm",
                        Saddle = "SDG FLY MTN 2, CrMo",
                        Tires = "Schwalbe Magic Mary, Addix-Soft, TLE, Kevlar, 27.5\" x 2.35\"",
                        Color = "stealth grey / deep black glossy",
                        Weight = "13,30 kg*",
                        FrameSize = "16\",18\", 20\"",
                        Pedals = "not included"


                    },
                         ShortDescription = "Whether it’s a flowing trail or rough and technical section – with a bike from the “All Mountain/Enduro” category, you’re ready for anything!",
                         LongDescription = "True to the saying \"hard outer,soft inner\", the JAB 9.0 HD with the stiff Rock Shox Lyrik in boost format and the Super Deluxe RC3 Debon Air will lure you out of your comfort zone. The e*thirteen TRS wheels respond the way you want no matter what the terrain. The high-quality SRAM X01 Eagle gears offer crisp, fast and precise shifting off-road plus a wide range. Control is everything so we use 780mm wide bars and a short stem from the Race Face Turbine R line. The SRAM Code R ensures grippy and responsive braking, and the SDG Vario seatpost gives you room to move. Let’s go. The mountains are calling!",
                         InStock = true,
                         ImageUrl = "/Content/Images/bikes/mount_JAB 9.0 HD.jpg",
                         ImageThumbnailUrl = "/Content/Images/bikes/mount_JAB 9.0 HD_Thumbnail.jpg",
                         IsBikeOfTheWeek = false
                     },


                    // FREERIDE
                    new Bike
                     {
                         Model = "SWOOP 170 9.0",
                         Price = 3299m,
                         Category = Categories["FREERIDE"],
                         Specifications =
                    new Specification
                    {
                        Frame = "SWOOP 170",
                        Fork = "Fox 36 Float, Performance Elite, 3pos, Boost",
                        RearSuspension = "Fox Float DPX2, Performance Elite, EVOL, 216x63",
                        TravelFork = "170mm",
                        TravelRearSuspension = "170mm",
                        Wheelset = "e*thirteen TRS, 110/148",
                        Brakes = "Magura MT5",
                        BrakeDiscs = "Magura Storm 203/180mm, 6-bolt",
                        Crank = "SRAM Descendant Eagle 7k, 32T, 170mm",
                        InnerBearing = "SRAM GXP, BSA 73",
                        Shifter = "SRAM GX EAGLE, 12-speed, Shiftmix",
                        RearDerailleur = "SRAM GX Eagle",
                        Cassette = "SRAM XG-1275, 10-50",
                        Chain = "SRAM GX",
                        Handlebar = "Race Face Atlas, 35 x 800 mm, 35mm rise",
                        Steam = "Race Face Turbine R, 35 x 40/40/50/50 mm",
                        Headset = "FSA, ZS44/ZS56",
                        Grips = "SDG Slater",
                        Seatpost = "Fox Transfer Performance, 31.6 x 125/150/150/150 mm",
                        Saddle = "SDG Fly MTN 2, CrMo",
                        Tires = "Schwalbe Magic Mary, Addix-Soft, TLE, Kevlar, 27.5\" x 2.35\"",
                        Color = "bright petrol / deep black glossy",
                        Weight = "13,70 kg*",
                        FrameSize = "16\",18\", 20\", 22\"",
                        Pedals = "not included"


                    },
                         ShortDescription = "Are bike parks, aggressive trails and jump lines your thing? Our models in the \"Freeride\" category are extremely versatile and are suited to ambitious racers.",
                         LongDescription = "Freeride outings require components that can cope with everything from drops to rock gardens while giving riders a sense of safety and confidence. Fox gives you the 36 Float Performance Elite air suspension with 3 damper modes and the new DPX2 EVOL air damper which noticeably smooths out small shocks while having good travel to deal with the hard rides. When there’s no mountain lift available, you’ll climb any ascent with the wide range, high-quality SRAM GX Eagle gears. Magura MT5 brakes are reliable and let you apply the right level of force for late braking manoeuvres.",
                         InStock = true,
                         ImageUrl = "/Content/Images/bikes/freed_SWOOP 170.jpg",
                         ImageThumbnailUrl = "/Content/Images/bikes/freed_SWOOP 170_Thumbnail.jpg",
                         IsBikeOfTheWeek = false
                     }
                    );
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "ROAD", Description = "Roadbikes, Triathlonbikes, Fitness- & Urbanbikes" },
                        new Category { CategoryName = "CROSS & TREKKING", Description = "Cross- & Trekkingbikes (Hybrid version incl.)" },
                        new Category { CategoryName = "CROSS COUNTRY", Description = "Mountainbikes with front suspension (Hybrid version incl.)" },
                        new Category { CategoryName = "MOUNTAIN", Description = "Full-Suspension Mountainbikes with max. 170mm travel (Hybrid version incl.)" },
                        new Category { CategoryName = "FREERIDE" , Description = "Full-Suspension Mountainbikes with max. 190mm travel"},
                        new Category { CategoryName = "DOWNHILL", Description ="Full-Suspension Mountainbikes with max. 210mm travel"}
                    
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
