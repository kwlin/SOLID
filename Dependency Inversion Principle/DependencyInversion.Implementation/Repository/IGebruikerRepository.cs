using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Implementation.Repository
{
    interface IGebruikerRepository
    {
        void Create();

        void Read();

        void Update();

        void Delete();
    }

    /*
    interface IGebruikerRepository
    {
        void VoegToe();

        // sql = insert
        // json = write/delete
    }*/
}
