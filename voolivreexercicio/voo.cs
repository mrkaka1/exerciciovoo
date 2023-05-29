public class VOO
{
    public int numbervoo;
    public DateTime datahr = new DateTime();
    public bool [] poltrona = new bool[100];

   public VOO(int number, DateTime data)
    {
        this.numbervoo = number;
        this.datahr = data;
    }

    public int ProximoLivre()
    {
        for (int i = 0; i < poltrona.Length; i++)
        {
            if (!poltrona[i])
            {
                return i + 1;
            }
        }
        return -1 ;
    }

    public bool Verifica(int numPoltrona)
    {
        if(numPoltrona> 0 && numPoltrona < 100 && !poltrona[numPoltrona - 1])
        {
            poltrona[numPoltrona - 1] = true;
            return true;
        }
        return false;
    }

    public bool Ocupa(int numpt)
    {
        if(numpt > 0 && numpt <= 100 && !poltrona[numpt - 1])
        {
            poltrona[numpt - 1] = true; 
            return true;
        }
        return false;
    }

    public int Vagas()
    {
        int vagas = 0;

        for(int i = 0; i < poltrona.Length; i++)
        {
            if (!poltrona[i])
            {
                vagas++;
            }
        }
        return vagas;
    }

    public int GetVOO()
    {
        return numbervoo;
    }
    public DateTime GetData()
    {
        return datahr;
    }
}