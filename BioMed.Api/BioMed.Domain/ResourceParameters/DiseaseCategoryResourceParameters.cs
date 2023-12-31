﻿namespace BioMed.Domain.ResourceParameters
{
    public class DiseaseCategoryResourceParameters : ResourceParametersBase
    {
        public override string OrderBy { get; set; } = "name";

        protected override int MaxPageSize { get; set; } = 50;
    }
}
