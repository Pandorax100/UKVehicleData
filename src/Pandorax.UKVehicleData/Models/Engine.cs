using System.Text.Json.Serialization;

namespace Pandorax.UKVehicleData.Models
{
    public class Engine
    {
        /// <summary>
        /// The method by which the engine breathes. E.g. 'NATURALLY ASPIRATED', 'SUPERCHARGER',
        /// 'TURBO'.
        /// </summary>
        [JsonPropertyName("Aspiration")]
        public string Aspiration { get; set; }

        /// <summary>
        /// Internal Diameter of the Engine Cylinder in (mm).
        /// </summary>
        [JsonPropertyName("Bore")]
        public double? Bore { get; set; }

        /// <summary>
        /// Physical Arrangement of the cylinders â€“ 'VEE' (The cylinders and pistons are aligned,
        /// in two separate planes or 'banks', so that they appear to be in a 'V' when viewed along
        /// the axis of the crankshaft) , 'INLINE' (Cylinders arranged in a single row side by side
        /// and parallel to one another).
        /// </summary>
        [JsonPropertyName("CylinderArrangement")]
        public string CylinderArrangement { get; set; }

        /// <summary>
        /// Manufacturer specific engine description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Fuel catalyst.
        /// </summary>
        [JsonPropertyName("FuelCatalyst")]
        public string FuelCatalyst { get; set; }

        /// <summary>
        /// Method of fuel delivery used.
        /// </summary>
        [JsonPropertyName("FuelDelivery")]
        public string FuelDelivery { get; set; }

        /// <summary>
        /// Summary description of fuel system.
        /// </summary>
        [JsonPropertyName("FuelSystem")]
        public string FuelSystem { get; set; }

        /// <summary>
        /// Location of the engine â€“ FRONT - A front-mounted engine describes the placement of an
        /// automobile engine in front of the vehicle passenger compartment. MIDDLE - A mid - engine
        /// layout describes the placement of an automobile engine between the rear and front axles).
        /// REAR - A rear - engine design layout places the engine at the rear of the vehicle.The
        /// center of gravity of the engine itself is past the rear axle.
        /// </summary>
        [JsonPropertyName("Location")]
        public string Location { get; set; }

        /// <summary>
        /// Brand name of the engine manufacturer e.g. 'Peugeot', 'Honda'.
        /// </summary>
        [JsonPropertyName("Make")]
        public string Make { get; set; }

        /// <summary>
        /// The number of cylinders in the engine.
        /// </summary>
        [JsonPropertyName("NumberOfCylinders")]
        public int? NumberOfCylinders { get; set; }

        /// <summary>
        /// 'Y' flag indicates principal fuel in multifuel vehicle.
        /// </summary>
        [JsonPropertyName("PrimaryFuelFlag")]
        public string PrimaryFuelFlag { get; set; }

        /// <summary>
        /// Distance between Top dead centre and Bottom dead centre of piston travel (mm).
        /// </summary>
        [JsonPropertyName("Stroke")]
        public double? Stroke { get; set; }

        /// <summary>
        /// The abbreviation of valve actuation mechanism type - 'SOHC' (Single OverHead Camshaft),
        /// 'DOHC' (Double OverHead Camshaft) or 'PUSHROD' (valves actuated by rocker arms actuated
        /// by 'pushrods') where known.
        /// </summary>
        [JsonPropertyName("ValveGear")]
        public string ValveGear { get; set; }

        /// <summary>
        /// The number of valves per cylinder (four stroke engines have at least 2 poppet valves per
        /// cylinder).
        /// </summary>
        [JsonPropertyName("ValvesPerCylinder")]
        public int? ValvesPerCylinder { get; set; }
    }
}
