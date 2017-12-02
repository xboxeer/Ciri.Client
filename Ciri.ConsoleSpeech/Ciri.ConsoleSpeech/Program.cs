using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baidu.Aip;
using Baidu.Aip.Speech;
using System.IO;

namespace Ciri.ConsoleSpeech
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var demo = new SpeechDemo();
            string message = Console.ReadLine();
            demo.Tts(message);
        }
    }

    public class SpeechDemo
    {
        private const string SPEECH_GENERATE_URL = "http://tsn.baidu.com/text2audio";
        private const string API_KEY = "2fwQEDdx0cInxdRvddf50Rae";
        private const string API_SECRITY_KEY = "HKm6ctFYwgOb59AxnQxohTSQuzAvWHmk";
        private const string APP_ID = "10469100";
        private readonly Asr _asrClient;
        private readonly Tts _ttsClient;

        public SpeechDemo()
        {
            _asrClient = new Asr(API_KEY, API_SECRITY_KEY);
            _ttsClient = new Tts(API_KEY, API_SECRITY_KEY);
        }

        // 合成
        public void Tts(string message)
        {
            // 可选参数
            var option = new Dictionary<string, object>()
            {
                {"spd", 5}, // 语速
                {"vol", 7}, // 音量
                {"per", 4}  // 发音人，4：情感度丫丫童声
            };
            var result = _ttsClient.Synthesis(message, option);

            if (result.ErrorCode == 0)  // 或 result.Success
            {
                File.WriteAllBytes("output.mp3", result.Data);
            }
        }
        
    }
}
