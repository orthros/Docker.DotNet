using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [DataContract]
    public class Config // (container.Config)
    {
        [DataMember(Name = "Hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

        [DataMember(Name = "Domainname", EmitDefaultValue = false)]
        public string Domainname { get; set; }

        [DataMember(Name = "User", EmitDefaultValue = false)]
        public string User { get; set; }

        [DataMember(Name = "AttachStdin", EmitDefaultValue = false)]
        public bool AttachStdin { get; set; }

        [DataMember(Name = "AttachStdout", EmitDefaultValue = false)]
        public bool AttachStdout { get; set; }

        [DataMember(Name = "AttachStderr", EmitDefaultValue = false)]
        public bool AttachStderr { get; set; }

        [DataMember(Name = "ExposedPorts", EmitDefaultValue = false)]
        public IDictionary<string, object> ExposedPorts { get; set; }

        [DataMember(Name = "Tty", EmitDefaultValue = false)]
        public bool Tty { get; set; }

        [DataMember(Name = "OpenStdin", EmitDefaultValue = false)]
        public bool OpenStdin { get; set; }

        [DataMember(Name = "StdinOnce", EmitDefaultValue = false)]
        public bool StdinOnce { get; set; }

        [DataMember(Name = "Env", EmitDefaultValue = false)]
        public IList<string> Env { get; set; }

        [DataMember(Name = "Cmd", EmitDefaultValue = false)]
        public IList<string> Cmd { get; set; }

        [DataMember(Name = "ArgsEscaped", EmitDefaultValue = false)]
        public bool ArgsEscaped { get; set; }

        [DataMember(Name = "Image", EmitDefaultValue = false)]
        public string Image { get; set; }

        [DataMember(Name = "Volumes", EmitDefaultValue = false)]
        public IDictionary<string, object> Volumes { get; set; }

        [DataMember(Name = "WorkingDir", EmitDefaultValue = false)]
        public string WorkingDir { get; set; }

        [DataMember(Name = "Entrypoint", EmitDefaultValue = false)]
        public IList<string> Entrypoint { get; set; }

        [DataMember(Name = "NetworkDisabled", EmitDefaultValue = false)]
        public bool NetworkDisabled { get; set; }

        [DataMember(Name = "MacAddress", EmitDefaultValue = false)]
        public string MacAddress { get; set; }

        [DataMember(Name = "OnBuild", EmitDefaultValue = false)]
        public IList<string> OnBuild { get; set; }

        [DataMember(Name = "Labels", EmitDefaultValue = false)]
        public IDictionary<string, string> Labels { get; set; }

        [DataMember(Name = "StopSignal", EmitDefaultValue = false)]
        public string StopSignal { get; set; }
    }
}
