using MelonLoader;
using ModData;

namespace TargetPracticeAndMasterHunter
{
    internal class SaveDataManager
    {
        ModDataManager dm = new ModDataManager("Reduced Loot", false);

        public void SerializeAndSaveArray(string[,] dataArray)
        {
            string serializedData = string.Join(";", dataArray.Cast<string>());
            dm.Save(serializedData, "records");
            //MelonLogger.Msg("Array serialized and saved.");
        }

        public string? Load(string suffix)
        {
            string? serializedData = dm.Load(suffix);

            return serializedData;
        }
    }
}


