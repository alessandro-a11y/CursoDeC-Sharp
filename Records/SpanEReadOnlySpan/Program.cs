using System;

class Program
{
    static void Main()
    {
        // Buffer recebido da rede
        byte[] networkBuffer =
        {
            0x01, 0x00, 0x00, 0x10, // Header
            10,20,30,40,50,60,70,80,
            90,100,110,120,
            0xFF,0xEE,0xDD,0xCC
        };

        Span<byte> packet = networkBuffer;

        Console.WriteLine("=== Buffer Original ===");
        Print(packet);

        // 1 - Slice()
        Span<byte> header = packet.Slice(0, 4);
        Span<byte> payload = packet.Slice(4, packet.Length - 8);
        Span<byte> footer = packet.Slice(packet.Length - 4, 4);

        Console.WriteLine("\nHeader:");
        Print(header);

        Console.WriteLine("\nPayload:");
        Print(payload);

        Console.WriteLine("\nFooter:");
        Print(footer);

        // 2 - CopyTo()
        byte[] payloadCopy = new byte[payload.Length];
        payload.CopyTo(payloadCopy);

        Console.WriteLine("\nPayload Copiado:");
        Print(payloadCopy);

        // 3 - Fill()
        payload.Fill(0xAA);

        Console.WriteLine("\nPayload sobrescrito:");
        Print(packet);

        // 4 - Clear()
        footer.Clear();

        Console.WriteLine("\nFooter limpo:");
        Print(packet);
    }

    static void Print(ReadOnlySpan<byte> data)
    {
        foreach (var b in data)
            Console.Write($"{b:X2} ");

        Console.WriteLine();
    }
}