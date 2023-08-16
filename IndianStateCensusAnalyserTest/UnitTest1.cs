using IndianStateCensusAnalyser;



namespace IndianStateCensusAnalyserTest
{
    public class Tests
    {
        public string stateCensusDataFilePath = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusData.csv";
        [Test]
        public void GivenStateCencusData_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCensusAnalyser.ReadStateCensusData(stateCensusDataFilePath), CSVStateCensus.ReadStateCensusData(stateCensusDataFilePath));
            Assert.Pass();
        }
    }
}