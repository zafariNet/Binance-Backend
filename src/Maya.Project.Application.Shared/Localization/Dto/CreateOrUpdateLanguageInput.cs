﻿using System.ComponentModel.DataAnnotations;

namespace Maya.Project.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}