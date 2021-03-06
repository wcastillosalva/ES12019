﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface ICursoRepository
    {
        List<CursoEntity> ObtenerCursos();
        CursoEntity ObtenerCurso(int id);
        void CrearCurso(CursoEntity nuevaCurso);
        void ModificarCurso(CursoEntity nuevo);
        void QuitarCurso(int id);
    }
}
