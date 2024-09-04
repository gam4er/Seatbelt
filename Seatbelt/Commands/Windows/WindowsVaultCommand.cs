using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using static O_F41F88FA.O_7A5E6AD0;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_19270373
    {
        public Guid SchemaGuidId { get; set; }
        public O_195F078A? Resource { get; set; }
        public O_195F078A? Identity { get; set; }
        public O_195F078A? PackageSid { get; set; }
        public O_195F078A? Credential { get; set; }
        public DateTime LastModifiedUtc { get; set; }
    }
internal class O_E3B1AD34 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("g6OtGSRSH9O1v68J").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1MrDfUslbIU=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("0JdN57sHN0/yiVujrQg1Q/fFQe3+HStDs7JB7boGNFWzs0n2sh1jDvrLTa3+BSxB+otbo7gbLEuzrEb3uxstQ+fFbfuuBSxU9pcI4rANY2P3gk2q8A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k+Uog95pQyY=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    private readonly Dictionary<Guid, string> VaultSchema = new Dictionary<Guid, string>
    {
        {
            new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("VHmTUp7kPFBLD5Qnmfw4UCV5jyvqkzlJVQmTIezpOlEgDecm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zj+iE6jRDGQ=")[iii % 8])).ToArray())),
            Encoding.UTF8.GetString(Convert.FromBase64String("rRlmODi7zyepFWspJamcSZUEbQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+nAIXFfMvAc=")[iii % 8])).ToArray())
        },
        {
            new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("skW9ExVqlZ2sPskWGHOY5rA20xYSb5mJtzbGbxhm6OCyRMti").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gQb+VyBerKQ=")[iii % 8])).ToArray())),
            Encoding.UTF8.GetString(Convert.FromBase64String("VC2M1Ld2oj5UIYCQiGCibXQrkNT4QqN7ZyGMxLFgvQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A0TisNgB0R4=")[iii % 8])).ToArray())
        },
        {
            new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("RAf/h1byXj1Ycf32UOwuSEN05vonhCwgQAL9+1b2KEtMC/KE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dTLLwmTBGg0=")[iii % 8])).ToArray())),
            Encoding.UTF8.GetString(Convert.FromBase64String("AFtdMheVfocUQFYyHYx5zjZeEwYRgWbCJRJjJBeWaMQjXUE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VzIzVnjiDac=")[iii % 8])).ToArray())
        },
        {
            new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("9CFWufxLU3PtWlK1/lJTcIFTPc+MR1dshCckzIhPUwWEISK1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wGMQjb9/Z0E=")[iii % 8])).ToArray())),
            Encoding.UTF8.GetString(Convert.FromBase64String("layVyddrYROnp4OA9XV3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wsn36ZQZBHc=")[iii % 8])).ToArray())
        },
        {
            new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("UVRjRyBt66BLJRFFI3jtp1dWDDBQbenPUFIWNyMX76RVIRM9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZmMhBBVV2eI=")[iii % 8])).ToArray())),
            Encoding.UTF8.GetString(Convert.FromBase64String("n7MyLRPG1K6LqDktGd/T56m2Lw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yNpcSXyxp44=")[iii % 8])).ToArray())
        },
        {
            new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("gKu8PuGZ0OLopLQ444zXnIakqELv5db39661PuLl15mGr8c5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xZ2Fetah49o=")[iii % 8])).ToArray())),
            Encoding.UTF8.GetString(Convert.FromBase64String("Xw1dIMo8kLJMC14lzCXD0W0WRy3DIoDzfAETB9cuh/dmEFolyQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CGQzRKVL45I=")[iii % 8])).ToArray())
        },
        {
            new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("tKG5gBhqurmq1cvyHHLMz8LTpIcTaMvRxqHN/Btuusq107yH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h+SJxStf+Pw=")[iii % 8])).ToArray())),
            Encoding.UTF8.GetString(Convert.FromBase64String("dV9uB+ztmXJmWW0C6vTKAkNFcxTs6I5yYURlB+b0njtDWg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IjYAY4Oa6lI=")[iii % 8])).ToArray())
        },
        {
            new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("nN8Y8mfqWt2Crhb8aIEor+6uDYtp6l7DnNoW/WSVXdmYqRTy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r5wgylGsHO4=")[iii % 8])).ToArray())),
            Encoding.UTF8.GetString(Convert.FromBase64String("+Ysm1KxOg1jrmjzVrV2VHI6hOtWnXJ4Mx4Mk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ruJIsMM58Hg=")[iii % 8])).ToArray())
        },
        {
            new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("4NUxSCmqqSb91TFIKbepJuDVLEgpqqk74NUxSCmqqSbg1TFI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0OUBeBmamRY=")[iii % 8])).ToArray())),
            Encoding.UTF8.GetString(Convert.FromBase64String("PZG4R+hZNg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AfPUJoYyCMk=")[iii % 8])).ToArray())
        }
    };
    public O_E3B1AD34(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var vaultCount = 0;
        var vaultGuidPtr = IntPtr.Zero;
        var result = VaultEnumerateVaults(0, ref vaultCount, ref vaultGuidPtr);
        var vaultItemType = Environment.OSVersion.Version > new Version(Encoding.UTF8.GetString(Convert.FromBase64String("ID9+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FhFMsZzb4lI=")[iii % 8])).ToArray())) ? typeof(VAULT_ITEM_WIN8) : typeof(VAULT_ITEM_WIN7);
        if (result != 0)
        {
            WriteError($"Unable to enumerate vaults. Error code: {result}");
            yield break;
        }

        var guidAddress = vaultGuidPtr;
        for (var i = 0; i < vaultCount; i++)
        {
            var vaultGuidString = Marshal.PtrToStructure(guidAddress, typeof(Guid));
            var vaultGuid = new Guid(vaultGuidString.ToString());
            guidAddress = (IntPtr)(guidAddress.ToInt64() + Marshal.SizeOf(typeof(Guid)));
            var vaultHandle = IntPtr.Zero;
            var vaultType = VaultSchema.ContainsKey(vaultGuid) ? VaultSchema[vaultGuid] : vaultGuid.ToString();
            result = VaultOpenVault(ref vaultGuid, (uint)0, ref vaultHandle);
            if (result != 0)
            {
                WriteError($"Unable to open the following vault(GUID: {vaultGuid}: {vaultType} . Error code: {result}");
                continue;
            }

            var entries = new List<O_19270373>();
            var vaultItemCount = 0;
            var vaultItemPtr = IntPtr.Zero;
            result = VaultEnumerateItems(vaultHandle, 512, ref vaultItemCount, ref vaultItemPtr);
            if (result != 0)
            {
                WriteError($"Unable to enumerate vault items from the following vault: {vaultType}. Error code: {result}");
                continue;
            }

            var currentVaultItem = vaultItemPtr;
            if (vaultItemCount > 0)
            {
                for (var j = 1; j <= vaultItemCount; j++)
                {
                    var entry = ParseVaultItem(vaultHandle, vaultGuid, currentVaultItem);
                    entries.Add(entry);
                    currentVaultItem = (IntPtr)(currentVaultItem.ToInt64() + Marshal.SizeOf(vaultItemType));
                }
            }

            yield return new O_70BC9C8D(vaultGuid, vaultType, entries);
        }
    }

    private void GetVaultItem(IntPtr vaultHandle, IntPtr vaultItemPtr, out Guid schemaId, out IntPtr? pPackageSid, out IntPtr pResourceElement, out IntPtr pIdentityElement, out ulong lastModified, out IntPtr pAuthenticatorElement)
    {
        int result;
        var OSVersion = Environment.OSVersion.Version;
        var vaultItemType = OSVersion > new Version(Encoding.UTF8.GetString(Convert.FromBase64String("tcUd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g+svq8hvuN8=")[iii % 8])).ToArray())) ? typeof(VAULT_ITEM_WIN8) : typeof(VAULT_ITEM_WIN7);
        var currentItem = Marshal.PtrToStructure(vaultItemPtr, vaultItemType);
        var schemaIdField = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("sDsHrfT+5Zo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("41hvyJmfrP4=")[iii % 8])).ToArray()));
        var tempSchemaGuidId = new Guid(schemaIdField.GetValue(currentItem).ToString());
        var pResourceElementField = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("eQMFESKa+vhsFAwHIIrm7w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CVFgYk3viJs=")[iii % 8])).ToArray()));
        var tempResourceElement = (IntPtr)pResourceElementField.GetValue(currentItem);
        var pIdentityElementField = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("Lcat1fX+lvckyqXV9u+R9w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XY/JsJuK/4M=")[iii % 8])).ToArray()));
        var tempIdentityElement = (IntPtr)pIdentityElementField.GetValue(currentItem);
        var lastModifiedField = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("+PBp55GlscPS+H/3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tJEak9zK1ao=")[iii % 8])).ToArray()));
        var tempLastModified = (ulong)lastModifiedField.GetValue(currentItem);
        IntPtr? tempPackageSid = null;
        if (vaultItemType == typeof(VAULT_ITEM_WIN8))
        {
            var pPackageSidInfo = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("kOoiAlX6fGez0yc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4LpDYT6bGwI=")[iii % 8])).ToArray()));
            tempPackageSid = (IntPtr)pPackageSidInfo.GetValue(currentItem);
        }

        var passwordVaultItem = IntPtr.Zero;
        result = vaultItemType == typeof(VAULT_ITEM_WIN8) ? VaultGetItem_WIN8(vaultHandle, ref tempSchemaGuidId, tempResourceElement, tempIdentityElement, tempPackageSid ?? IntPtr.Zero, IntPtr.Zero, 0, ref passwordVaultItem) : VaultGetItem_WIN7(vaultHandle, ref tempSchemaGuidId, tempResourceElement, tempIdentityElement, IntPtr.Zero, 0, ref passwordVaultItem);
        if (result != 0)
            throw new Exception($"Could not retrieve vault vault item. Error code: {result}");
        schemaId = tempSchemaGuidId;
        pPackageSid = tempPackageSid;
        pResourceElement = tempResourceElement;
        pIdentityElement = tempIdentityElement;
        lastModified = tempLastModified;
        var passwordItem = Marshal.PtrToStructure(passwordVaultItem, vaultItemType);
        var pAuthenticatorElementInfo = passwordItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("lwVFzfuR3zWOJ1HN/Ib0LYIpVdfn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("50QwuZP0sUE=")[iii % 8])).ToArray()));
        pAuthenticatorElement = (IntPtr)pAuthenticatorElementInfo.GetValue(passwordItem);
    }

    private O_19270373 ParseVaultItem(IntPtr vaultHandle, Guid vaultGuid, IntPtr vaultItemPtr)
    {
        GetVaultItem(vaultHandle, vaultItemPtr, out var schemaGuid, out var pPackageSid, out var pResourceElement, out var pIdentityElement, out var lastModified, out var pAuthenticatorElement);
        O_195F078A? cred = null;
        try
        {
            cred = GetVaultElementValue(pAuthenticatorElement);
        }
        catch (NotImplementedException e)
        {
            WriteError($"Could not parse authenticator for Vault GUID {vaultGuid}: {e}");
        }

        O_195F078A? packageSid = null;
        if (pPackageSid != null && pPackageSid != IntPtr.Zero)
        {
            try
            {
                packageSid = GetVaultElementValue(pPackageSid.Value);
            }
            catch (NotImplementedException e)
            {
                WriteError($"Could not parse package SID for Vault GUID {vaultGuid}: {e}");
            }
        }

        O_195F078A? resource = null;
        try
        {
            resource = GetVaultElementValue(pResourceElement);
        }
        catch (NotImplementedException e)
        {
            WriteError($"Could not parse authenticator for Vault GUID {vaultGuid}: {e}");
        }

        O_195F078A? identity = null;
        try
        {
            identity = GetVaultElementValue(pIdentityElement);
        }
        catch (NotImplementedException e)
        {
            WriteError($"Could not parse identity for Vault GUID {vaultGuid}: {e}");
        }

        return new O_19270373
        {
            SchemaGuidId = schemaGuid,
            Identity = identity,
            Resource = resource,
            Credential = cred,
            PackageSid = packageSid,
            LastModifiedUtc = DateTime.FromFileTimeUtc((long)lastModified)
        };
    }

    private O_195F078A GetVaultElementValue(IntPtr vaultElementPtr)
    {
        object value;
        var item = (VAULT_ITEM_ELEMENT)Marshal.PtrToStructure(vaultElementPtr, typeof(VAULT_ITEM_ELEMENT));
        var elementPtr = (IntPtr)(vaultElementPtr.ToInt64() + 16);
        switch (item.Type)
        {
            case VAULT_ELEMENT_TYPE.Boolean:
                value = Marshal.ReadByte(elementPtr);
                value = (bool)value;
                break;
            case VAULT_ELEMENT_TYPE.Short:
                value = Marshal.ReadInt16(elementPtr);
                break;
            case VAULT_ELEMENT_TYPE.UnsignedShort:
                value = Marshal.ReadInt16(elementPtr);
                break;
            case VAULT_ELEMENT_TYPE.Int:
                value = Marshal.ReadInt32(elementPtr);
                break;
            case VAULT_ELEMENT_TYPE.UnsignedInt:
                value = Marshal.ReadInt32(elementPtr);
                break;
            case VAULT_ELEMENT_TYPE.Double:
                value = Marshal.PtrToStructure(elementPtr, typeof(double));
                break;
            case VAULT_ELEMENT_TYPE.Guid:
                value = Marshal.PtrToStructure(elementPtr, typeof(Guid));
                break;
            case VAULT_ELEMENT_TYPE.String:
                var StringPtr = Marshal.ReadIntPtr(elementPtr);
                value = Marshal.PtrToStringUni(StringPtr);
                break;
            case VAULT_ELEMENT_TYPE.Sid:
                var sidPtr = Marshal.ReadIntPtr(elementPtr);
                var sidObject = new System.Security.Principal.SecurityIdentifier(sidPtr);
                value = sidObject.Value;
                break;
            case VAULT_ELEMENT_TYPE.ByteArray:
                var o = (VAULT_BYTE_ARRAY)Marshal.PtrToStructure(elementPtr, typeof(VAULT_BYTE_ARRAY));
                var array = new byte[o.Length];
                if (o.Length > 0)
                {
                    Marshal.Copy(o.pData, array, 0, o.Length);
                }

                value = array;
                break;
            default:
                throw new NotImplementedException($"VAULT_ELEMENT_TYPE '{item.Type}' is currently not implemented");
        }

        return new O_195F078A(item.Type, value);
    }

internal class O_70BC9C8D : O_4AED570F
{
    public O_70BC9C8D(Guid vaultGuid, string vaultType, List<O_19270373> vaultEntries)
    {
        VaultGUID = vaultGuid;
        VaultType = vaultType;
        VaultEntries = vaultEntries;
    }

    public Guid VaultGUID { get; set; }
    public string VaultType { get; set; }
    public List<O_19270373> VaultEntries { get; set; }
}    [CommandOutputType(typeof(O_70BC9C8D))]
    internal class O_80287F36 : TextFormatterBase
    {
        public O_80287F36(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_70BC9C8D)result;
            WriteLine($"\n  Vault GUID     : {dto.VaultGUID}");
            WriteLine($"  Vault Type     : {dto.VaultType}");
            WriteLine($"  Item count     : {dto.VaultEntries.Count}");
            foreach (var entry in dto.VaultEntries)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("eGNPnb8Q25EwJgLc2EXhlnhjT4e/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WENvvZ8wiPI=")[iii % 8])).ToArray()) + entry.SchemaGuidId);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("470xfdNi8sKw8mQvkCeAh+O9MWfT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w50RXfNCoKc=")[iii % 8])).ToArray()) + ItemToString(entry.Resource));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("B9mb5Uq8F85Cl8+sHuV+igfZm/9K").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J/m7xWqcXqo=")[iii % 8])).ToArray()) + ItemToString(entry.Identity));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gwKk9n9wyMXASeWxOgPxwIMCpOx/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oyKE1l9QmKQ=")[iii % 8])).ToArray()) + ItemToString(entry.PackageSid));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("TX0D5sUmOhMIOUaokW8YDU19A/zF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bV0jxuUGeWE=")[iii % 8])).ToArray()) + ItemToString(entry.Credential));
                WriteLine($"      LastModified : {entry.LastModifiedUtc}");
            }
        }

        private string ItemToString(O_195F078A? item)
        {
            if (item == null)
                return Encoding.UTF8.GetString(Convert.FromBase64String("3W8bbx9V").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9QFuA3N8JEs=")[iii % 8])).ToArray());
            string valueStr;
            switch (item.VaultElementType)
            {
                case VAULT_ELEMENT_TYPE.Boolean:
                case VAULT_ELEMENT_TYPE.Short:
                case VAULT_ELEMENT_TYPE.UnsignedShort:
                case VAULT_ELEMENT_TYPE.Int:
                case VAULT_ELEMENT_TYPE.UnsignedInt:
                case VAULT_ELEMENT_TYPE.Double:
                case VAULT_ELEMENT_TYPE.Guid:
                case VAULT_ELEMENT_TYPE.String:
                case VAULT_ELEMENT_TYPE.Sid:
                    valueStr = $"String: {item.Value.ToString()}";
                    break;
                case VAULT_ELEMENT_TYPE.ByteArray:
                    valueStr = BitConverter.ToString((byte[])item.Value).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("iw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("piR+7Jf6De0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("XA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fDAfq9y+ltc=")[iii % 8])).ToArray()));
                    ;
                    break;
                default:
                    valueStr = $"Unable to print a value of type {item.VaultElementType}. Please report an issue!";
                    break;
            }

            return valueStr;
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string lMrvMgtA)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Version instance = new System.Version();
                        instance.ToString(8);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_70BC9C8D)result;
            WriteLine($"\n  Vault GUID     : {dto.VaultGUID}");
            WriteLine($"  Vault Type     : {dto.VaultType}");
            WriteLine($"  Item count     : {dto.VaultEntries.Count}");
            foreach (var entry in dto.VaultEntries)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("eGNPnb8Q25EwJgLc2EXhlnhjT4e/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WENvvZ8wiPI=")[iii % 8])).ToArray()) + entry.SchemaGuidId);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("470xfdNi8sKw8mQvkCeAh+O9MWfT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w50RXfNCoKc=")[iii % 8])).ToArray()) + ItemToString(entry.Resource));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("B9mb5Uq8F85Cl8+sHuV+igfZm/9K").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J/m7xWqcXqo=")[iii % 8])).ToArray()) + ItemToString(entry.Identity));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gwKk9n9wyMXASeWxOgPxwIMCpOx/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oyKE1l9QmKQ=")[iii % 8])).ToArray()) + ItemToString(entry.PackageSid));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("TX0D5sUmOhMIOUaokW8YDU19A/zF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bV0jxuUGeWE=")[iii % 8])).ToArray()) + ItemToString(entry.Credential));
                WriteLine($"      LastModified : {entry.LastModifiedUtc}");
            }
        }

        private string ItemToString(O_195F078A? item, string ZOusInzB)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Version instance = new System.Version();
                        instance.ToString(8);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            if (item == null)
                return Encoding.UTF8.GetString(Convert.FromBase64String("3W8bbx9V").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9QFuA3N8JEs=")[iii % 8])).ToArray());
            string valueStr;
            switch (item.VaultElementType)
            {
                case VAULT_ELEMENT_TYPE.Boolean:
                case VAULT_ELEMENT_TYPE.Short:
                case VAULT_ELEMENT_TYPE.UnsignedShort:
                case VAULT_ELEMENT_TYPE.Int:
                case VAULT_ELEMENT_TYPE.UnsignedInt:
                case VAULT_ELEMENT_TYPE.Double:
                case VAULT_ELEMENT_TYPE.Guid:
                case VAULT_ELEMENT_TYPE.String:
                case VAULT_ELEMENT_TYPE.Sid:
                    valueStr = $"String: {item.Value.ToString()}";
                    break;
                case VAULT_ELEMENT_TYPE.ByteArray:
                    valueStr = BitConverter.ToString((byte[])item.Value).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("iw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("piR+7Jf6De0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("XA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fDAfq9y+ltc=")[iii % 8])).ToArray()));
                    ;
                    break;
                default:
                    valueStr = $"Unable to print a value of type {item.VaultElementType}. Please report an issue!";
                    break;
            }

            return valueStr;
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string mIFrcCVT)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Version instance = new System.Version();
                    instance.ToString(8);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var vaultCount = 0;
        var vaultGuidPtr = IntPtr.Zero;
        var result = VaultEnumerateVaults(0, ref vaultCount, ref vaultGuidPtr);
        var vaultItemType = Environment.OSVersion.Version > new Version(Encoding.UTF8.GetString(Convert.FromBase64String("ID9+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FhFMsZzb4lI=")[iii % 8])).ToArray())) ? typeof(VAULT_ITEM_WIN8) : typeof(VAULT_ITEM_WIN7);
        if (result != 0)
        {
            WriteError($"Unable to enumerate vaults. Error code: {result}");
            yield break;
        }

        var guidAddress = vaultGuidPtr;
        for (var i = 0; i < vaultCount; i++)
        {
            var vaultGuidString = Marshal.PtrToStructure(guidAddress, typeof(Guid));
            var vaultGuid = new Guid(vaultGuidString.ToString());
            guidAddress = (IntPtr)(guidAddress.ToInt64() + Marshal.SizeOf(typeof(Guid)));
            var vaultHandle = IntPtr.Zero;
            var vaultType = VaultSchema.ContainsKey(vaultGuid) ? VaultSchema[vaultGuid] : vaultGuid.ToString();
            result = VaultOpenVault(ref vaultGuid, (uint)0, ref vaultHandle);
            if (result != 0)
            {
                WriteError($"Unable to open the following vault(GUID: {vaultGuid}: {vaultType} . Error code: {result}");
                continue;
            }

            var entries = new List<O_19270373>();
            var vaultItemCount = 0;
            var vaultItemPtr = IntPtr.Zero;
            result = VaultEnumerateItems(vaultHandle, 512, ref vaultItemCount, ref vaultItemPtr);
            if (result != 0)
            {
                WriteError($"Unable to enumerate vault items from the following vault: {vaultType}. Error code: {result}");
                continue;
            }

            var currentVaultItem = vaultItemPtr;
            if (vaultItemCount > 0)
            {
                for (var j = 1; j <= vaultItemCount; j++)
                {
                    var entry = ParseVaultItem(vaultHandle, vaultGuid, currentVaultItem);
                    entries.Add(entry);
                    currentVaultItem = (IntPtr)(currentVaultItem.ToInt64() + Marshal.SizeOf(vaultItemType));
                }
            }

            yield return new O_70BC9C8D(vaultGuid, vaultType, entries);
        }
    }

    private void GetVaultItem(IntPtr vaultHandle, IntPtr vaultItemPtr, out Guid schemaId, out IntPtr? pPackageSid, out IntPtr pResourceElement, out IntPtr pIdentityElement, out ulong lastModified, out IntPtr pAuthenticatorElement, string usZfVEnI)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Version instance = new System.Version();
                    instance.ToString(8);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        int result;
        var OSVersion = Environment.OSVersion.Version;
        var vaultItemType = OSVersion > new Version(Encoding.UTF8.GetString(Convert.FromBase64String("tcUd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g+svq8hvuN8=")[iii % 8])).ToArray())) ? typeof(VAULT_ITEM_WIN8) : typeof(VAULT_ITEM_WIN7);
        var currentItem = Marshal.PtrToStructure(vaultItemPtr, vaultItemType);
        var schemaIdField = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("sDsHrfT+5Zo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("41hvyJmfrP4=")[iii % 8])).ToArray()));
        var tempSchemaGuidId = new Guid(schemaIdField.GetValue(currentItem).ToString());
        var pResourceElementField = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("eQMFESKa+vhsFAwHIIrm7w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CVFgYk3viJs=")[iii % 8])).ToArray()));
        var tempResourceElement = (IntPtr)pResourceElementField.GetValue(currentItem);
        var pIdentityElementField = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("Lcat1fX+lvckyqXV9u+R9w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XY/JsJuK/4M=")[iii % 8])).ToArray()));
        var tempIdentityElement = (IntPtr)pIdentityElementField.GetValue(currentItem);
        var lastModifiedField = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("+PBp55GlscPS+H/3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tJEak9zK1ao=")[iii % 8])).ToArray()));
        var tempLastModified = (ulong)lastModifiedField.GetValue(currentItem);
        IntPtr? tempPackageSid = null;
        if (vaultItemType == typeof(VAULT_ITEM_WIN8))
        {
            var pPackageSidInfo = currentItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("kOoiAlX6fGez0yc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4LpDYT6bGwI=")[iii % 8])).ToArray()));
            tempPackageSid = (IntPtr)pPackageSidInfo.GetValue(currentItem);
        }

        var passwordVaultItem = IntPtr.Zero;
        result = vaultItemType == typeof(VAULT_ITEM_WIN8) ? VaultGetItem_WIN8(vaultHandle, ref tempSchemaGuidId, tempResourceElement, tempIdentityElement, tempPackageSid ?? IntPtr.Zero, IntPtr.Zero, 0, ref passwordVaultItem) : VaultGetItem_WIN7(vaultHandle, ref tempSchemaGuidId, tempResourceElement, tempIdentityElement, IntPtr.Zero, 0, ref passwordVaultItem);
        if (result != 0)
            throw new Exception($"Could not retrieve vault vault item. Error code: {result}");
        schemaId = tempSchemaGuidId;
        pPackageSid = tempPackageSid;
        pResourceElement = tempResourceElement;
        pIdentityElement = tempIdentityElement;
        lastModified = tempLastModified;
        var passwordItem = Marshal.PtrToStructure(passwordVaultItem, vaultItemType);
        var pAuthenticatorElementInfo = passwordItem.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("lwVFzfuR3zWOJ1HN/Ib0LYIpVdfn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("50QwuZP0sUE=")[iii % 8])).ToArray()));
        pAuthenticatorElement = (IntPtr)pAuthenticatorElementInfo.GetValue(passwordItem);
    }

    private O_19270373 ParseVaultItem(IntPtr vaultHandle, Guid vaultGuid, IntPtr vaultItemPtr, string GiRpapBt)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Version instance = new System.Version();
                    instance.ToString(8);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        GetVaultItem(vaultHandle, vaultItemPtr, out var schemaGuid, out var pPackageSid, out var pResourceElement, out var pIdentityElement, out var lastModified, out var pAuthenticatorElement);
        O_195F078A? cred = null;
        try
        {
            cred = GetVaultElementValue(pAuthenticatorElement);
        }
        catch (NotImplementedException e)
        {
            WriteError($"Could not parse authenticator for Vault GUID {vaultGuid}: {e}");
        }

        O_195F078A? packageSid = null;
        if (pPackageSid != null && pPackageSid != IntPtr.Zero)
        {
            try
            {
                packageSid = GetVaultElementValue(pPackageSid.Value);
            }
            catch (NotImplementedException e)
            {
                WriteError($"Could not parse package SID for Vault GUID {vaultGuid}: {e}");
            }
        }

        O_195F078A? resource = null;
        try
        {
            resource = GetVaultElementValue(pResourceElement);
        }
        catch (NotImplementedException e)
        {
            WriteError($"Could not parse authenticator for Vault GUID {vaultGuid}: {e}");
        }

        O_195F078A? identity = null;
        try
        {
            identity = GetVaultElementValue(pIdentityElement);
        }
        catch (NotImplementedException e)
        {
            WriteError($"Could not parse identity for Vault GUID {vaultGuid}: {e}");
        }

        return new O_19270373
        {
            SchemaGuidId = schemaGuid,
            Identity = identity,
            Resource = resource,
            Credential = cred,
            PackageSid = packageSid,
            LastModifiedUtc = DateTime.FromFileTimeUtc((long)lastModified)
        };
    }

    private O_195F078A GetVaultElementValue(IntPtr vaultElementPtr, string CTUsSLhk)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Version instance = new System.Version();
                    instance.ToString(8);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        object value;
        var item = (VAULT_ITEM_ELEMENT)Marshal.PtrToStructure(vaultElementPtr, typeof(VAULT_ITEM_ELEMENT));
        var elementPtr = (IntPtr)(vaultElementPtr.ToInt64() + 16);
        switch (item.Type)
        {
            case VAULT_ELEMENT_TYPE.Boolean:
                value = Marshal.ReadByte(elementPtr);
                value = (bool)value;
                break;
            case VAULT_ELEMENT_TYPE.Short:
                value = Marshal.ReadInt16(elementPtr);
                break;
            case VAULT_ELEMENT_TYPE.UnsignedShort:
                value = Marshal.ReadInt16(elementPtr);
                break;
            case VAULT_ELEMENT_TYPE.Int:
                value = Marshal.ReadInt32(elementPtr);
                break;
            case VAULT_ELEMENT_TYPE.UnsignedInt:
                value = Marshal.ReadInt32(elementPtr);
                break;
            case VAULT_ELEMENT_TYPE.Double:
                value = Marshal.PtrToStructure(elementPtr, typeof(double));
                break;
            case VAULT_ELEMENT_TYPE.Guid:
                value = Marshal.PtrToStructure(elementPtr, typeof(Guid));
                break;
            case VAULT_ELEMENT_TYPE.String:
                var StringPtr = Marshal.ReadIntPtr(elementPtr);
                value = Marshal.PtrToStringUni(StringPtr);
                break;
            case VAULT_ELEMENT_TYPE.Sid:
                var sidPtr = Marshal.ReadIntPtr(elementPtr);
                var sidObject = new System.Security.Principal.SecurityIdentifier(sidPtr);
                value = sidObject.Value;
                break;
            case VAULT_ELEMENT_TYPE.ByteArray:
                var o = (VAULT_BYTE_ARRAY)Marshal.PtrToStructure(elementPtr, typeof(VAULT_BYTE_ARRAY));
                var array = new byte[o.Length];
                if (o.Length > 0)
                {
                    Marshal.Copy(o.pData, array, 0, o.Length);
                }

                value = array;
                break;
            default:
                throw new NotImplementedException($"VAULT_ELEMENT_TYPE '{item.Type}' is currently not implemented");
        }

        return new O_195F078A(item.Type, value);
    }
}
    internal class O_195F078A
    {
        public O_195F078A(VAULT_ELEMENT_TYPE vaultElementType, object value)
        {
            VaultElementType = vaultElementType;
            Value = value;
        }

        public VAULT_ELEMENT_TYPE VaultElementType { get; set; }
        public object Value { get; set; }
    }
}