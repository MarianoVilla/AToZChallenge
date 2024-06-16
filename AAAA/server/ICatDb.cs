public interface ICatDb {

    Task<IEnumerable<CatFact>> GetCatFacts();

}