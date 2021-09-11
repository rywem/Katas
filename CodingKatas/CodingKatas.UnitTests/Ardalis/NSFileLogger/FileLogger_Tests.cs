using CodingKatas.Ardalis.NSFileLogger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
namespace CodingKatas.UnitTests.Ardalis.NSFileLogger
{
    [Collection("Sequential")]
    public class FileLogger_Tests
    {
        private FileLogger _logger = new FileLogger();
        private string _testMessage = Guid.NewGuid().ToString();
        private string GetFileName()
        {
            string dateString = DateTime.Today.ToString("yyyy-MM-dd");
            return $"log{dateString}.txt";
        }
        [Fact]
        public void AppendMessageToLogFile()
        {
            _logger.Log(_testMessage);            
            var fileContents = System.IO.File.ReadAllText(GetFileName());
            Assert.Contains(_testMessage, fileContents);
        }

        [Fact]
        public void AppendMessageToLogFileWithCurrentTime()
        {
            string dateString = DateTime.Today.ToString("yyyy-MM-dd");
            _logger.Log(_testMessage);
            var fileContents = File.ReadAllText(GetFileName());
            Assert.Contains(dateString, fileContents);
        }

        [Fact]
        public void AppendMessageToLogFileNamedForToday()
        {
            string expectedFileName = GetFileName();
            _logger.Log(_testMessage);            
            Assert.True(File.Exists(expectedFileName));
        }

        [Fact]
        public void CreateNewFileOnNewDay()
        {
            DateTime firstDate = new DateTime(2021, 03, 19, 23, 59, 59);
            DateTime secondDate = firstDate.AddMinutes(1);
            string expectedFileName = "log2021-03-20.txt";
            var fakeDateTime = new FakeDateTime();
            var logger = new FileLogger(fakeDateTime, new DefaultFileNameStrategy());
            fakeDateTime.Now = firstDate;
            logger.Log("foo"); // firstDate
            fakeDateTime.Now = secondDate;
            logger.Log(_testMessage); // secondDate
            Assert.True(File.Exists(expectedFileName));
        }

        [Theory]
        [InlineData(2021, 3, 20)]
        [InlineData(2021, 3, 21)]
        public void LogsToWeekendFileOnWeekend(int year, int month, int day)
        {
            DateTime weekendDate = new DateTime(year, month, day);
            var fakeDateTime = new FakeDateTime();
            var logger = new FileLogger(fakeDateTime, new DefaultFileNameStrategy());
            fakeDateTime.Now = weekendDate;
            logger.Log("foo"); // firstDate            
            string expectedFileName = "weekend.txt";
            Assert.True(File.Exists(expectedFileName));
        }
    }
}
