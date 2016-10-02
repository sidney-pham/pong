' 100% credit goes to Ram Kaniyur: https://github.com/quadrupleslap
' Send him your money for this solution around the issue of not being able to play sounds
' simultaneously. It's actually really smart, and I'm pretty sure it's not on the internet
' either, so...

' Requirements:
' - Ensure all audio has the same bit resolution, sampling rate and channels (stereo/mono).
'   That 's what Ram told me, at least...

Imports NAudio.Wave
Public Module GlobalTrack
    Private Device As New WaveOutEvent
    Private Format As WaveFormat
    Private Mixer As SampleProviders.MixingSampleProvider

    Sub New()
        Format = WaveFormat.CreateIeeeFloatWaveFormat(44100, 2)
        Device = New WaveOutEvent()
        Mixer = New SampleProviders.MixingSampleProvider(Format)
        Mixer.ReadFully = True

        Device.Init(Mixer)
        Device.Play()
    End Sub

    Public Sub PlaySound(snd As IO.Stream)
        Dim x = New WaveFileReader(snd)
        Mixer.AddMixerInput(x.ToSampleProvider)
    End Sub
End Module
