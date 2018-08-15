using System.IO;
using CSharpJSON;

namespace MakeHumanMhx2Merger
{
    sealed class Mhx2Model
    {

        private readonly string path;
        private readonly JSONObject json;


        public Mhx2Model(string path)
        {
            this.path = path;
            json = new JSONObject(File.ReadAllText(path));
        }


        public string GetPath()
        {
            return path;
        }


        public void Save(string path)
        {
            File.WriteAllText(path, json.ToString());
        }


        public string[] GetSkeletonBoneNames()
        {
            JSONArray array = json.GetJSONObject("skeleton").GetJSONArray("bones");
            int size = array.Length();
            string[] result = new string[size];
            for (int i = 0; i < size; ++i)
            {
                result[i] = array.GetJSONObject(i).GetString("name");
            }
            return result;
        }

        public string[] GetMaterialNames()
        {
            JSONArray array = json.GetJSONArray("materials");
            int size = array.Length();
            string[] result = new string[size];
            for (int i = 0; i < size; ++i)
            {
                result[i] = array.GetJSONObject(i).GetString("name");
            }
            return result;
        }

        public string[] GetGeometryNames()
        {
            JSONArray array = json.GetJSONArray("geometries");
            int size = array.Length();
            string[] result = new string[size];
            for (int i = 0; i < size; ++i)
            {
                result[i] = array.GetJSONObject(i).GetString("name");
            }
            return result;
        }


        public JSONObject GetSkeletonBone(int index)
        {
            return json.GetJSONObject("skeleton").GetJSONArray("bones").GetJSONObject(index);
        }

        public JSONObject GetMaterial(int index)
        {
            return json.GetJSONArray("materials").GetJSONObject(index);
        }

        public JSONObject GetGeometry(int index)
        {
            return json.GetJSONArray("geometries").GetJSONObject(index);
        }


        public void AddSkeletonBone(JSONObject obj)
        {
            json.GetJSONObject("skeleton").GetJSONArray("bones").Put(obj);
        }

        public void AddMaterial(JSONObject obj)
        {
            json.GetJSONArray("materials").Put(obj);
        }

        public void AddGeometry(JSONObject obj)
        {
            json.GetJSONArray("geometries").Put(obj);
        }
    }
}
