namespace Pandorax.UKVehicleData.Models
{
    public class Dimensions
    {
        /// <summary>
        /// Additional Variant Description field for commercial vehicles to
        /// allow relative roof heights and body shape versions of same variant.
        /// </summary>
        public string BodyShape { get; set; }

        /// <summary>
        /// The distance in millimetres between a vertical line at the front bumper
        /// of the vehicle to a similar line at the most extreme point at the rear of the vehicle.
        /// </summary>
        public double? CarLength { get; set; }

        /// <summary>
        /// Version number for this data.
        /// </summary>
        public double? DataVersionNumber { get; set; }

        /// <summary>
        /// Capacity of vehicle fuel tank in litres.
        /// </summary>
        public double? FuelTankCapacity { get; set; }

        /// <summary>
        /// Standard abbreviation: GCW. The total maximum weight of
        /// an articulated vehicle as driven, i.e. with semi-trailer,
        /// payload, driver and all fluids.
        /// </summary>
        public double? GrossCombinedWeight { get; set; }

        /// <summary>
        /// Standard abbreviation: GTW. The total maximum weight of a rigid vehicle
        /// together with its loaded draw-bar trailer. (NOTE: Sometimes manufacturers
        /// use the term GCW for both rigid and articulated vehicles).
        /// </summary>
        public double? GrossTrainWeight { get; set; }

        /// <summary>
        /// Standard abbreviation: GVW. The total maximum weight of a
        /// rigid vehicle as driven, i.e. with body, payload, driver and all fluids.
        /// </summary>
        public double? GrossVehicleWeight { get; set; }

        /// <summary>
        /// The distance in millimetres from a horizontal line touching the highest
        /// point of the vehicle roof to the point of contact with the road surface.
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// The weight of the complete vehicle and all equipment without payload or driver.
        /// </summary>
        public double? KerbWeight { get; set; }

        /// <summary>
        /// Measured in millimetres at floor level from behind the
        /// driver's seat to the end of floor space.
        /// </summary>
        public double? LoadLength { get; set; }

        /// <summary>
        /// Total number of Axles.
        /// </summary>
        public int? NumberOfAxles { get; set; }

        /// <summary>
        /// Number of doors the vehicle has.
        /// </summary>
        public int? NumberOfDoors { get; set; }

        /// <summary>
        /// Total number of seats to include driver as specified on the Certificate of Conformity.
        /// </summary>
        public int? NumberOfSeats { get; set; }

        /// <summary>
        /// The cubic capacity of the load space for the vehicle measured in cubic metres.
        /// (This value is entered for factory built panel vans. For other body types and
        /// chassis cabs, the equivalent for the panel van version in the range may be entered).
        /// </summary>
        public double? PayloadVolume { get; set; }

        /// <summary>
        /// Descriptive field that indicates if the vehicle has a
        /// permanent or semi permanent pivoting joint (Artic) or not (Rigid).
        /// </summary>
        public string RigidArtic { get; set; }

        /// <summary>
        /// Standard abbreviation: ULW. The total weight of an unladen
        /// vehicle with body, less driver, ready for operation on the road.
        /// </summary>
        public double? UnladenWeight { get; set; }

        /// <summary>
        /// The distance in Millimeters between the front and rear axles.
        /// </summary>
        public double? WheelBase { get; set; }

        /// <summary>
        /// The distance in Millimetres between two vertical lines touching the opposite sides of the vehicle excluding the Wing Mirrors.
        /// </summary>
        public double? Width { get; set; }
    }
}
