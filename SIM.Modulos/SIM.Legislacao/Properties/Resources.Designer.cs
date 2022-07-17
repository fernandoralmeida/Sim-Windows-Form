﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sim.Legislacao.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sim.Legislacao.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT        TipoOrigem, NumeroOrigem, ComplementoOrigem, DataOrigem, Acao
        ///FROM            LegislacaoAcoes
        ///WHERE (TipoAlvo = @Tipo) AND (NumeroAlvo = @Numero) AND  (ComplementoAlvo = @Comp).
        /// </summary>
        internal static string AcoesRecebidas {
            get {
                return ResourceManager.GetString("AcoesRecebidas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM  LegislacaoAcoes.
        /// </summary>
        internal static string AcoesSemFiltro {
            get {
                return ResourceManager.GetString("AcoesSemFiltro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  * FROM            Legislacao
        ///WHERE        (Tipo LIKE @Tipo) AND (Data BETWEEN @Data1 AND @Data2) AND (Resumo LIKE &apos;%&apos; +  @Resumo + &apos;%&apos;) AND (Classificado LIKE @Classificado) AND (Situacao LIKE @Situacao) 
        ///AND (Origem LIKE @Origem) AND (Autor LIKE &apos;%&apos; + @Autor + &apos;%&apos;) AND (Excluido = 0)
        ///ORDER BY Data DESC, Numero DESC.
        /// </summary>
        internal static string SelectDetalhado {
            get {
                return ResourceManager.GetString("SelectDetalhado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Legislacao WHERE (Excluido = 0) ORDER BY Data DESC, Numero DESC.
        /// </summary>
        internal static string SelectSemFiltro {
            get {
                return ResourceManager.GetString("SelectSemFiltro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Legislacao WHERE (Tipo LIKE @Tipo) AND (Numero = @Numero) AND (Complemento LIKE @Complemento) AND (Excluido = 0) ORDER BY Data DESC, Numero DESC.
        /// </summary>
        internal static string SelectSimples {
            get {
                return ResourceManager.GetString("SelectSimples", resourceCulture);
            }
        }
    }
}