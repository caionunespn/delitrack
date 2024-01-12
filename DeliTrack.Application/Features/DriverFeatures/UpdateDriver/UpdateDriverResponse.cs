namespace DeliTrack.Application.Features.DriverFeatures.UpdateDriver;

public sealed record UpdateDriverResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool ShowPosition { get; set; }
    public double CurrentPosLatitude { get; set; }
    public double CurrentPosLongitude { get; set; }
}