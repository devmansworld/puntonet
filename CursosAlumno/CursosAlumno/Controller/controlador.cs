using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursosAlumno.Model;
using CursosAlumno.View;

namespace CursosAlumno.Controller
{
    class controlador
    {
        #region Curso
        static List<curso> lcurso = new List<curso>();
        public bool vidCurso(int id)
        {
            try 
            {
                foreach (curso c in lcurso)
                {
                    if (c.IdC == id)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool vNombreC(string nombre)
        {
            try
            {
                foreach (curso c in lcurso)
                {
                    if (c.NombreC == nombre)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool addCurso(int id, string nombre)
        {
            try 
            {
                curso c = new curso(id,nombre);
                lcurso.Add(c);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public void cargaInicialCurso()
        {
            try
            {
                foreach (curso c in lcurso)
                {
                    if (c.IdC == 1 && c.NombreC == "Taller 1")
                    {
                        deleteCurso(1);
                    }
                    else if (c.IdC == 2 && c.NombreC == "Taller 2")
                    {
                        deleteCurso(2);
                    }
                    else if (c.IdC == 3 && c.NombreC == "Taller 3")
                    {
                        deleteCurso(3);
                    }
                }
                curso c1 = new curso(1, "Taller 1");
                curso c2 = new curso(2, "Taller 2");
                curso c3 = new curso(3, "Taller 3");
            }
            catch { }
        }
        public bool updateCurso(int id, string nombre)
        {
            try 
            {
                foreach (curso c in lcurso)
                {
                    if (c.IdC == id)
                    {
                        c.NombreC = nombre;
                        return true;
                    }
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }
        public bool deleteCurso(int id)
        {
            try 
            {
                foreach (curso c in lcurso)
                {
                    if (c.IdC == id)
                    {
                        lcurso.Remove(c);
                        return true;
                    }
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }
        public void cargaGrillaC(DataGridView d)
        {
            try
            {
                deleteCurso(0);
                d.Rows.Clear();
                d.Columns.Clear();
                DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn nom = new DataGridViewTextBoxColumn();
                id.HeaderText = "ID";
                nom.HeaderText = "Curso";
                d.Columns.Add(id);
                d.Columns.Add(nom);
                int ancho = d.Width;
                id.Width = (20 * ancho) / 100;
                nom.Width = (80 * ancho)/ 100;
                d.RowHeadersVisible = false;
                d.AllowUserToAddRows = false;
                d.DataSource = null;
                foreach (curso c in lcurso)
                {
                    string idA = c.IdC.ToString();
                    string ccA = c.NombreC.ToString();
                    d.Rows.Add(idA, ccA);
                }
            }
            catch { }
        }
        #endregion

        #region Alumno
        static List<alumno> lAlumno = new List<alumno>();
        public void cargaCBAlumno(ComboBox cb)
        {
            try
            {
                deleteCurso(0);
                addCurso(0, " Seleccione un curso");
            }
            catch { }
            cb.DataSource = null;
            lcurso.Sort((a, b) => string.Compare(a.NombreC, b.NombreC));
            lcurso = lcurso.OrderBy(a => a.NombreC).ToList();
            cb.DataSource = lcurso;
            cb.DisplayMember = "NombreC";
            cb.ValueMember = "IdC";
        }
        public curso rCurso(int id)
        {
            curso sal = new curso();
            try
            {
                foreach (curso c in lcurso)
                {
                    if (c.IdC == id)
                    {
                        sal = c;
                        return sal;
                    }
                }
                return sal;
            }
            catch 
            {
                return sal;
            }
        }
        public int ridCurso(string nC)
        {
            int sal = 0;
            try
            {
                foreach (curso c in lcurso)
                {
                    if (c.NombreC == nC)
                    {
                        sal = c.IdC;
                        return sal;
                    }
                }
                return sal;
            }
            catch
            {
                return sal;
            }
        }
        public bool addAlumno(int idA, string nombreA, string appatA, string apmatA, string rutA, int idC)
        {
            try 
            {
                curso rc = rCurso(idC);
                alumno a = new alumno(idA,nombreA,appatA,apmatA,rutA,rc);
                lAlumno.Add(a);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool updateAlumno(int idA, string nombreA, string appatA, string apmatA, string rutA, int idC)
        {
            try 
            {
                foreach (alumno a in lAlumno)
                {
                    if (a.IdA == idA)
                    {
                        curso c = rCurso(idC);
                        a.NombreA = nombreA;
                        a.AppatA = appatA;
                        a.ApmatA = apmatA;
                        a.RutA = rutA;
                        a.CursoA = c;
                        return true;
                    }
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }
        public bool deleteAlumno(int idA)
        {
            try 
            {
                foreach (alumno a in lAlumno)
                {
                    if (a.IdA == idA)
                    {
                        lAlumno.Remove(a);
                        return true;
                    }
                }
                return false;
            }
            catch 
            {
                return false;
            }
        }
        public void cargaGrillaA(DataGridView d)
        {
            d.Rows.Clear();
            d.Columns.Clear();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn appat = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn apmat = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn rut = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn curso = new DataGridViewTextBoxColumn();
            id.HeaderText = "ID";
            nombre.HeaderText = "Nombre";
            appat.HeaderText = "A.Paterno";
            apmat.HeaderText = "A.Materno";
            rut.HeaderText = "Rut";
            curso.HeaderText = "Curso";
            d.Columns.Add(id);
            d.Columns.Add(nombre);
            d.Columns.Add(appat);
            d.Columns.Add(apmat);
            d.Columns.Add(rut);
            d.Columns.Add(curso);
            int ancho = d.Width;
            id.Width = (10 * ancho) / 100;
            nombre.Width = (15 * ancho) / 100;
            appat.Width = (15 * ancho) / 100;
            apmat.Width = (15 * ancho) / 100;
            rut.Width = (15 * ancho) / 100;
            curso.Width = (30 * ancho) / 100;
            d.RowHeadersVisible = false;
            d.AllowUserToAddRows = false;
            foreach (alumno a in lAlumno)
            {
                string idA = a.IdA.ToString();
                string nnA = a.NombreA.ToString();
                string apA = a.AppatA.ToString();
                string amA = a.ApmatA.ToString();
                string rtA = a.RutA.ToString();
                curso c = a.CursoA;
                string csA = c.NombreC.ToString();
                d.Rows.Add(idA, nnA,apA, amA,rtA,csA);
            }

        }
        public string nombCurso(int id)
        {
            try 
            {
                foreach (curso c in lcurso)
                {
                    if (c.IdC == id)
                    {
                        return c.NombreC;
                    }
                }
                return "";
            }
            catch 
            {
                return "";
            }
        }
        #endregion
    }
}
