using IndianStateCensusAnalyser;



namespace IndianStateCensusAnalyserTest
{
    public class Tests
    {
        public string stateCensusDataFilePath2 = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\State.csv";
        public string stateCensusDataFilePath = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensusData.csv";
        public string stateCensusDataFilePath1 = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCensus.csv";

        public string stateCodeDataFilePath = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCode.csv";
        public string stateCodeDataTxtFilePath = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCode.txt";
        public string stateCodeDataNotExistFilePath = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCod.csv";
        public string stateCodeDataHeaderFilePath = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCodeHeader.csv";
        public string stateCodeDataDelimeterFilePath = @"D:\Problem statemets\IndianStateCensusAnalyser\IndianStateCensusAnalyser\Files\StateCodeDelimeter.csv";

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
                StateCensusAnalyser.ReadStateCensusData(stateCodeDataTxtFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            }

        }
        [Test]
        public void GivenStateCencusDataFileNotExists_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadStateCensusData(stateCodeDataNotExistFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "File not exists");
            }

        }
        [Test]
        public void GivenStateCensusHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadStateCensusData(stateCodeDataHeaderFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Header Incorrect");
            }
        }
        [Test]
        public void GivenStateCensusDelimeterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadStateCensusData(stateCodeDataDelimeterFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter Incorrect");
            }
        }
        //-----
        [Test]
        public void GivenStateCodeData_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCodeAnalyser.ReadStateCodeData(stateCodeDataFilePath), CSVStateCode.ReadStateCodeData(stateCodeDataFilePath));
            Assert.Pass();
        }
        [Test]
        public void GivenStateCodeDataFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataTxtFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            }

        }
        [Test]
        public void GivenStateCodeDataFileNotExists_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataNotExistFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "File not exists");
            }

        }
        [Test]
        public void GivenStateCodeHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataHeaderFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Header Incorrect");
            }
        }
        [Test]
        public void GivenStateCodeDelimeterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataDelimeterFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter Incorrect");
            }
        }
    }
}