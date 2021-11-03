using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelData
{
    public class TableEntry
    {
        public uint index;
        public uint originalPointer; // DONT SAVE THIS
        public bool bHasData;  // DONT SAVE THIS
        public string name; // DONT SAVE THIS (??)
        public int size;

        public static StringBuilder nameSB;

        public virtual bool isAnmChrEdit { get; internal set; }

        public TableEntry()
        {
            name = "";
        }

        public virtual void GuessName()
        {
            switch(index)
            {
                case 0x0:
                    name = "Idle Stance";
                    break;
                case 0x1:
                    name = "Walk Forward";
                    break;
                case 0x2:
                    name = "Walk Backward";
                    break;
                case 0x3:
                    name = "Ground Dash Forward";
                    break;
                case 0x4:
                    name = "Ground Dash Backward";
                    break;
                case 0x5:
                    name = "Air Dash Forward";
                    break;
                case 0x6:
                    name = "Air Dash Backward";
                    break;
                case 0x9:
                    name = "Fall";
                    break;
                case 0xA:
                    name = "Crouch";
                    break;
                case 0xC:
                    name = "Jump";
                    break;
                case 0xD:
                    name = "Jump Forward";
                    break;
                case 0xE:
                    name = "Jump Backward";
                    break;
                case 0xF:
                    name = "Midair Jump";
                    break;
                case 0x10:
                    name = "Midair Jump Forward";
                    break;
                case 0x11:
                    name = "Midair Jump Backward";
                    break;
                case 0x13:
                    name = "Super Jump";
                    break;
                case 0x14:
                    name = "Super Jump Forward";
                    break;
                case 0x15:
                    name = "Super Jump Backward";
                    break;
                case 0x16:
                    name = "Special Fall?";
                    break;
                case 0x17:
                    name = "Light Landing";
                    break;
                case 0x18:
                    name = "Turn";
                    break;
                case 0x19:
                    name = "Crouch Exit";
                    break;
                case 0x1A:
                    name = "Crouch Turn";
                    break;
                case 0x24:
                    name = "Grab Teched";
                    break;
                case 0x25:
                    name = "Grab Tech";
                    break;
                case 0x26:
                    name = "Air Grab Teched";
                    break;
                case 0x27:
                    name = "Air Grab Tech";
                    break;
                case 0x82:
                    name = "Intro Animation";
                    break;
                case 0x83:
                    name = "Intro Animation Assist 1";
                    break;
                case 0x84:
                    name = "Intro Animation Assist 2";
                    break;
                case 0x85:
                    name = "Assist Exit After Intro";
                    break;    
                case 0x87:
                    name = "Taunt";
                    break;
                case 0x89:
                    name = "Victory Animation";
                    break;
                case 0x8B:
                    name = "Time Over Defeat";
                    break;*/
                case 0xA9:
                    name = "Air X-Factor";
                    break;
                case 0xAA:
                    name = "X-Factor";
                    break;
                case 0xAB:
                    name = "Snap Back";
                    break;
                case 0xAC:
                    name = "Assist Alpha";
                    break;
                case 0xAD:
                    name = "Assist Beta";
                    break;
                case 0xAE:
                    name = "Assist Gamma";
                    break;
                case 0x106:
                    name = "Air Forward Throw";
                    break;
                case 0x107:
                    name = "Air Backward Throw";
                    break;
                case 0x154:
                    name = "Tag In";
                    break;
                case 0x155:
                    name = "Tag Out";
                    break;
                case 0x157:
                    name = "Assist Leaving";
                    break;
                case 0x159:
                    name = "Crossover Combination";
                    break;
                case 0x16A:
                    name = "TAC Up";
                    break;
                case 0x16B:
                    name = "TAC Side";
                    break;
                case 0x16C:
                    name = "TAC Down";
                    break;
                case 0x168:
                    name = "Stand S";
                    break;
                case 0x170:
                    name = "TAC Tag In Up";
                    break;
                case 0x171:
                    name = "TAC Tag In Side";
                    break;
                case 0x172:
                    name = "TAC Tag In Down";
                    break;
                case 0x17C:
                    name = "Flight Entry";
                    break;
                case 0x17D:
                    name = "Air Flight Entry";
                    break;
                case 0x17E:
                    name = "Flight Exit";
                    break;
                case 0x17F:
                    name = "Flight Idle";
                    break;
                case 0x180:
                    name = "Flight Forward";
                    break;
                case 0x181:
                    name = "Flight Up+Forward";
                    break;
                case 0x182:
                    name = "Flight Down+Forward";
                    break;
                case 0x183:
                    name = "Flight Back";
                    break;
                case 0x184:
                    name = "Flight Up+Back";
                    break;
                case 0x185
                    name = "Flight Down+Back";
                    break;
                case 0x186
                    name = "Flight Up";
                    break;
                case 0x187
                    name = "Flight Down";
                    break;
                case 0x1B8
                    name = "Gallery Pose";
                    break;
                default:
                    name = "unknown";
                    break;
            }
        }

        //TODO: try and implement to use char name
        public virtual string GuessStatusFieldName()
        {
            if (index >= 0)
            {
                return "Form #" + (index +1);
            }
            return "unknown";
        }

        public virtual string GuessAnmChrEntry(string currentEntry)
        {
            //if (currentEntry.Contains())
            //{

            //}
            return currentEntry;
        }

        public virtual string GuessFieldName()
        {
            switch (index)
            {

                case 0:
                    name = "Tag-in";
                    break;
                case 1:
                    name = "TAC partner tag-in";
                    break;
                /*case 2:
                    name = "";
                    break;*/
                case 3:
                    name = "Snap Back";
                    break;
                case 4:
                    name = "st.S";
                    break;
                case 5:
                    name = "Team Aerial Counter";
                    break;
                case 6:
                    name = "TAC Up";
                    break;
                case 7:
                    name = "TAC Side";
                    break;
                 case 8:
                    name = "TAC Down";
                    break; 
                /*case 9:
                    name = "Fall";
                    break;
                case 10:
                    name = "Crouch";
                    break;
                case 11:
                    name = "";
                    break;*/
                case 30:
                    name = "st.L";
                    break;
                case 31:
                    name = "st.M";
                    break;
                case 32:
                    name = "st.H";
                    break;
                case 33:
                    name = "cr.L";
                    break;
                case 34:
                    name = "cr.M";
                    break;
                case 35:
                    name = "cr.H";
                    break;
                case 36:
                    name = "j.L";
                    break;
                case 37:
                    name = "j.M";
                    break;
                case 38:
                    name = "j.H";
                    break;
                case 39:
                    name = "j.S";
                    break;

                /*case 0x0:
                return "stand";
            case 0x1:
                return "fwd walk";
            case 0x3:
                return "fwd dash";
            case 0x4:
                return "backdash";
            case 0x96:
                return "5L";
            case 0x168:
                return "5S";*/
                default:
                    name = "unknown";
                    break;
            }

            if ((index >= 40 && index <= 49) && HasAtkFlags())
            {
                return "Command Move " + (index - 39);
            }

            if ((index >= 50 && index <= 79) && HasAtkFlags())
            {
                return "Special Move " + (index - 49);
            }

            if ((index >= 80 && index <= 99) && HasAtkFlags())
            {
                return "Hyper Move " + (index - 79);
            }

            if (index >= 100 && HasAtkFlags())
            {
                return "Assist " + (index - 99);
            }

            return name;
        }

        public virtual string GetFancyName()
        {
            if(nameSB == null)
            {
                nameSB = new StringBuilder();
            }
            else
            {
                nameSB.Clear();
            }
            nameSB.Append(index.ToString("X3"));
            nameSB.Append("h: ");
            //if (tabletype != null && tabletype.Contains("ATKInfo"))
            if (this.GetType().ToString().Contains("ATKInfo"))
            {
                nameSB.Append(GuessFieldName());
            }
            //else if (tabletype != null && tabletype.Contains("Status"))
            else if (this.GetType().ToString().Contains("Status"))
            {
                nameSB.Append(GuessStatusFieldName());
            }
            else
            {
            nameSB.Append(name);
            }
            if (this.GetType().ToString().Contains("cmdspatk"))
            {
                return GuessAnmChrEntry(nameSB.ToString());
            }
            return  nameSB.ToString();
        }

        public virtual string GetFilename()
        {
            if(name == "unknown")
            {
                return index.ToString("X3") + "unk";
            }
            else
            {
                return name;
            }
        }

        public virtual byte[] GetData()
        {
            throw new NotImplementedException();
        }

        public virtual void SetData(byte[] newdata)
        {
            // need to set size here too
            throw new NotImplementedException();
        }

        public void Export(string filename)
        {
            AELogger.Log("exporting " + GetFancyName() + " to " + filename);
            if (File.Exists(filename))
            {
                try
                {
                    File.Copy(filename, "exportbackup", true);
                }
                catch (UnauthorizedAccessException e)
                {
                    AELogger.Log("unable to access export backup: " + e.Message);
                }

            }
            Stream t = new FileStream(filename + ".temp", FileMode.Create);
            BinaryWriter b = new BinaryWriter(t);

            b.Write(GetData());

            b.Close();
            t.Close();
            File.Copy(filename + ".temp", filename, true);
            File.Delete(filename + ".temp");
        }

        public void Import(string filename)
        {
            if (File.Exists(filename))
            {
                AELogger.Log("importing file " + filename + " to " + GetFancyName());
                using (BinaryReader reader = new BinaryReader(File.OpenRead(filename)))
                {
                    if (reader.BaseStream.Length == 0)
                    {
                        bHasData = false;
                        name = "***EMPTY DATA ***";
                    }
                    else
                    {
                        if (!bHasData)
                        {
                            bHasData = true;
                            try
                            {
                                name = Path.GetFileNameWithoutExtension(filename);
                            }
                            catch
                            {
                                GuessName();
                            }
                        }
                        ImportBytes(reader.ReadBytes((int)reader.BaseStream.Length));
                    }
                }
            }
            else
            {
                AELogger.Log("attempted import of nonexistent file " + filename + " to " + GetFancyName());
            }
        }

        public virtual void ImportBytes(byte[] bytes)
        {
            SetData(bytes);
        }

        public virtual TableEntry Duplicate()
        {
            TableEntry dupe = (TableEntry)Activator.CreateInstance(GetType());
            dupe.name = "duplicate " + name;
            dupe.size = size;
            dupe.ImportBytes(GetData());
            return dupe;
        }

        public virtual void UpdateSize()
        {

        }

        public virtual Boolean HasAtkFlags()
        {
            if ((((MarvelData.StructEntry<MarvelData.ATKInfoChunk>)this).@data).atkflags != 0)
            {
                return true;
            }
            return false;
        }
        
        public virtual int getSpatkHeaderSize()
        {
            if ((((MarvelData.StructEntry<MarvelData.SpatkHeaderChunk>)this).@data).size != 0)
            {
                return (((MarvelData.StructEntry<MarvelData.SpatkHeaderChunk>)this).@data).size;
            }
            return 0;
        }    
                
        public virtual void setSpatkHeaderSize(int newSize)
        {
            if ((((MarvelData.StructEntry<MarvelData.SpatkHeaderChunk>)this).@data).size != 0)
            {
                (((MarvelData.StructEntry<MarvelData.SpatkHeaderChunk>)this).@data).size = newSize;
            }
        }    

        public virtual int getCmdComboSpatkHeaderSize()
        {
            if ((((MarvelData.StructEntry<MarvelData.CmdComboHeaderChunk>)this).@data).size != 0)
            {
                return (((MarvelData.StructEntry<MarvelData.CmdComboHeaderChunk>)this).@data).size;
            }
            return 0;
        }
        
        public virtual void setCmdComboSpatkHeaderSize(int newSize)
        {
            if ((((MarvelData.StructEntry<MarvelData.CmdComboHeaderChunk>)this).@data).size != 0)
            {
                (((MarvelData.StructEntry<MarvelData.CmdComboHeaderChunk>)this).@data).size = newSize;
            }
        }    

        public virtual StructEntry<SpatkHeaderChunk> getSpatkHeader()
        {
            throw new NotImplementedException();
        }
        
        public virtual StructEntry<CollisionHeaderChunk> getCollisionHeader()
        {
            throw new NotImplementedException();
        }
    }
}
