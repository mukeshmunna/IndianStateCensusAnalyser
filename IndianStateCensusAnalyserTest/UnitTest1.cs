using IndianStateCensusAnalyser;



namespace IndianStateCensusAnalyserTest
{
    public class Tests
    {
        public string stateCensusDataFilePath2 = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\State.csv";
        public string stateCensusDataFilePath = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusData.csv";
        public string stateCensusDataFilePath1 = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensus.csv";

        [Test]
        public void GivenStateCencusData_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCensusAnalyser.ReadStateCensusData(stateCensusDataFilePath), CSVStateCensus.ReadStateCensusData(stateCensusDataFilePath));
            Assert.Pass();
        }
        [Test]
        public void GivenStateCencusDataFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadStateCensusData(stateCensusDataFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            }

        }
        [Test]

        public void GivenStateCensusNoData_WhenAnalysed_ShouldReturnException()

        {

            try

            {

                StateCensusAnalyser.ReadStateCensusData(stateCensusDataFilePath2);

            }

            catch (CensusAnalyserException ex)

            {

                Assert.AreEqual(ex.Message, "File Not Exist");

            }
        }
            [Test]

            public void GivenStateCensusHeaderincorrect_WhenAnalysed_ShouldReturnException()

            {

                try

                {

                    StateCensusAnalyser.ReadStateCensusData(stateCensusDataFilePath1);

                }

                catch (CensusAnalyserException ex)

                {

                    Assert.AreEqual(ex.Message, "Header incorrect");

                }


            }
        }
}