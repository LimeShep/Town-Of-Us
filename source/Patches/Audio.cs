using System;
using System.IO;
using UnityEngine;

namespace TownOfUs
{
    public class Audio
    {
        public static byte[] ReadFully(Stream input)
        {
            using (var ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public static class WavUtility
        {
            // Converts byte array of WAV data to an AudioClip.
            public static AudioClip ToAudioClip(byte[] data, string clipName)
            {
                WAV wav = new WAV(data);
                AudioClip audioClip = AudioClip.Create(clipName, wav.SampleCount, wav.ChannelCount, wav.Frequency, false);
                audioClip.SetData(wav.LeftChannel, 0);
                return audioClip;
            }
        }

        public class WAV
        {
            public int ChannelCount { get; private set; }
            public int SampleCount { get; private set; }
            public int Frequency { get; private set; }
            public float[] LeftChannel { get; private set; }

            public WAV(byte[] data)
            {
                ChannelCount = BitConverter.ToInt16(data, 22);
                Frequency = BitConverter.ToInt32(data, 24);
                int subchunk2 = BitConverter.ToInt32(data, 40);
                SampleCount = subchunk2 / 2;  // 2 bytes per sample (assuming 16-bit WAV)

                LeftChannel = new float[SampleCount];
                for (int i = 0; i < SampleCount; i++)
                {
                    LeftChannel[i] = BitConverter.ToInt16(data, 44 + i * 2) / 32768f;
                }
            }
        }
    }
}
