using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;


namespace FoodTracker.Service
{
    public static class FirebaseConnecter
    {
        //public static void Connect() 
        //{
        //    string path = AppDomain.CurrentDomain.BaseDirectory + "foodtracker-774f6.json";
        //    Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

        //    FirestoreDb db = FirestoreDb.Create("foodtracker-774f6");

        //}

        //public async Task<FirestoreDb> initFirestore()
        //{
        //    try
        //    {
        //        var stream = await FileSystem.OpenAppPackageFileAsync(Constants.FirestoreKeyFilename);
        //        var reader = new StreamReader(stream);
        //        var contents = reader.ReadToEnd();

        //        FirestoreClientBuilder fbc = new FirestoreClientBuilder { JsonCredentials = contents };
        //        return FirestoreDb.Create(Constants.FirestoreProjectID, fbc.Build());
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
