using System.Security.Cryptography; namespace Arq.Lab.Library.Security; public static class SecureRandomFacade { public static int Next() => RandomNumberGenerator.GetInt32(100, 999); }
