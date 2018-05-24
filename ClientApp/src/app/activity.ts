export class Activty {
    constructor(
        public Id: number,
        public UserId: number,
        public DateTime: DateTimeFormat,
        public DurationOfActivity?: string,
        public Notes?: string,
        public Reps?: number,
        public Weight?: number,
      ) { }
}
