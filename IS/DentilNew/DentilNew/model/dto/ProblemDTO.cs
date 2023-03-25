using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto
{
    public class ProblemDTO
    {
        private TypeProblemDTO typeProblemDto;
        private int tooth;
        private int idVisit;

        public ProblemDTO(TypeProblemDTO typeProblemDto, int tooth, int idVisit)
        {
            this.tooth = tooth;
            this.typeProblemDto = typeProblemDto;
            this.idVisit = idVisit;
        }

        public ProblemDTO(TypeProblemDTO typeProblemDto, int tooth)
        {
            this.tooth = tooth;
            this.typeProblemDto = typeProblemDto;
        }

        public int Tooth
        {
            get { return tooth; }
        }

        public TypeProblemDTO TypeProblemDto
        {
            get { return typeProblemDto; }
        }

        public int IdVisit
        {
            get { return idVisit; }
            set { idVisit = value; }
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
                return false;

            ProblemDTO p = obj as ProblemDTO;
            if ((System.Object)p == null)
                return false;

            return p.tooth == tooth && p.typeProblemDto.Id == typeProblemDto.Id;
        }

    }
}
