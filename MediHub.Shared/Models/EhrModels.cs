using System;

namespace MediHub.Shared.Models;

public class Vital
{
    public string Name { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Unit { get; set; } = string.Empty;
    public DateTime TakenAt { get; set; }
}

public class Problem
{
    public string Description { get; set; } = string.Empty;
    public DateTime DiagnosedDate { get; set; }
    public string Severity { get; set; } = string.Empty;
}

public class Document
{
    public string FileName { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public DateTime UploadedAt { get; set; }
    public string Category { get; set; } = string.Empty;
}

public class Appointment
{
    public string PatientName { get; set; } = string.Empty;
    public string Reason { get; set; } = string.Empty;
    public DateTime Time { get; set; }
    public string Status { get; set; } = "Confirmed";
    public string Type { get; set; } = "Consultation";
}
