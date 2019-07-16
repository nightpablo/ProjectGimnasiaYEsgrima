
using ProjectGimnasiaYEsgrima.Modelo;
using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima;
using System;
using System.Globalization;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestDatos
    {
        private List<Deporte> deportes;
        private List<Categoria> categorias;
        private List<Empleado> empleados;
        private List<Persona> personas;
        private List<Socio> socios;
        private List<Login> logins;
        private List<CuotaSocio> cuotassocios;
        private List<ValorCuotaInicial> cuotasiniciales;
        private List<RegistroIngresoEgreso> registros;


        [OneTimeSetUp] //Esta funcion comienza a inicializar las variables antes de comenzar todas las pruebas
        public void Test1EjecutarOrdenado()
        {
            //Inicializamos todas las variables
            deportes = new List<Deporte>();//
            categorias = new List<Categoria>();//
            empleados = new List<Empleado>();//
            personas = new List<Persona>();//
            socios = new List<Socio>();//
            logins = new List<Login>();//
            cuotassocios = new List<CuotaSocio>();//
            cuotasiniciales = new List<ValorCuotaInicial>();//
            registros = new List<RegistroIngresoEgreso>();//
        }

        

        [Test,Order(1)]
        public void Test2DeporteControladorBD()
        {

            ControladorDeporte controladorDeporte = new ControladorDeporte();

            

            //Aceptado
            Assert.IsTrue(controladorDeporte.CrearDeporte("FutbolPrueba", "pepeeejd") > 0);
            Assert.IsTrue(controladorDeporte.CrearDeporte("NatacionPrueba", "") > 0);
            Deporte deporte_buscado = controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba");
            Assert.IsNotNull(deporte_buscado);
            Assert.IsTrue(controladorDeporte.ListarTodosDeportes().Count > 0);
            Assert.IsTrue(controladorDeporte.ListarTodosDeportesPorFiltros("ut", "").Count > 0);
            Assert.IsTrue(controladorDeporte.ModificarDeporte(deporte_buscado.IdDeporte, "FutbolPrueba", "Futbol en Testing") > 0);
            Assert.IsTrue(controladorDeporte.ListarTodosDeportesPorFiltros("", "Futbol en Test").Count > 0);
            //Error
            Assert.AreEqual(controladorDeporte.CrearDeporte("FutbolPrueba", ""), -2);
            Assert.IsFalse(controladorDeporte.ListarTodosDeportesPorFiltros("z", "").Count > 0);
            Assert.IsFalse(controladorDeporte.ListarTodosDeportesPorFiltros("", "z").Count > 0);
            //Eliminación
            Assert.IsTrue(controladorDeporte.EliminarDeporte(deporte_buscado) > 0);
            deporte_buscado = controladorDeporte.BuscarDeportePorClavesUnicas("NatacionPrueba");
            Assert.IsTrue(controladorDeporte.EliminarDeporte(deporte_buscado) > 0); //Como que se eliminaron todo, todavia debe existir en la bd pero en estado BAJA
            //Recuperación
            Assert.IsTrue(controladorDeporte.CrearDeporte("FutbolPrueba", "Recuperando Futbol") == -1);
            Assert.IsTrue(controladorDeporte.CrearDeporte("NatacionPrueba", "Recuperando Natacion") == -1);

            deportes.Add(controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba"));
            deportes.Add(controladorDeporte.BuscarDeportePorClavesUnicas("NatacionPrueba"));

        }
        [Test, Order(2)]
        public void Test3CategoriaControladorBD()
        {
            // Una vez ejecutada el testing de Deporte debieron haber sido creado 2 deportes nuevos
            ControladorDeporte controladorDeporte = new ControladorDeporte();
            ControladorCategoria controladorCategoria = new ControladorCategoria();

            DateTime Inicio = DateTime.ParseExact("01/08/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime Fin = DateTime.ParseExact("30/11/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //Aceptado
            Assert.IsTrue(controladorCategoria.CrearCategoria("FutbolPrueba 2do cuastrimestre 2018", 600, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")) > 0);
            Assert.IsTrue(controladorCategoria.CrearCategoria("NatacionPrueba 2do cuastimestre 2018", 500, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("NatacionPrueba")) > 0);
            Categoria Categoria_buscado = controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018");
            Assert.IsNotNull(Categoria_buscado);
            Assert.IsTrue(controladorCategoria.ListarTodosCategorias().Count > 0);
            Assert.IsTrue(controladorCategoria.ListarTodosCategoriasFiltro("cuastr", controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")).Count > 0);
            Assert.IsTrue(controladorCategoria.ModificarCategoria(Categoria_buscado.IdCategoria, "FutbolPrueba 2do cuastrimestre 2018", 1200, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba"), EnumEstadoCategoria.Pendiente) > 0);
            //Error
            Assert.AreEqual(controladorCategoria.CrearCategoria("FutbolPrueba 2do cuastrimestre 2018", 600, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")), -2);
            Assert.IsFalse(controladorCategoria.ListarTodosCategoriasFiltro("z", controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")).Count > 0);
            Assert.IsFalse(controladorCategoria.ListarTodosCategoriasFiltro("FutbolPrueba", controladorDeporte.BuscarDeportePorClavesUnicas("NatacionPrueba")).Count > 0);
            //Eliminación
            Assert.IsTrue(controladorCategoria.EliminarCategoria(Categoria_buscado) > 0);
            Categoria_buscado = controladorCategoria.BuscarCategoriaPorClavesUnicas("NatacionPrueba 2do cuastimestre 2018");
            Assert.IsTrue(controladorCategoria.EliminarCategoria(Categoria_buscado) > 0); //Como que se eliminaron todo, todavia debe existir en la bd pero en estado BAJA
            //Recuperación
            Assert.IsTrue(controladorCategoria.CrearCategoria("FutbolPrueba 2do cuastrimestre 2018", 9950, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("FutbolPrueba")) == -1);
            Assert.IsTrue(controladorCategoria.CrearCategoria("NatacionPrueba 2do cuastimestre 2018", 6540, Inicio, Fin, controladorDeporte.BuscarDeportePorClavesUnicas("NatacionPrueba")) == -1);

            categorias.Add(controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018"));
            categorias.Add(controladorCategoria.BuscarCategoriaPorClavesUnicas("NatacionPrueba 2do cuastimestre 2018"));
        }
        [Test, Order(3)]
        public void Test4EmpleadoControladorBD()
        {
            // Una vez ejecutada los testings anteriores debieron haber sido creado los nuevos datos antes de continuar con esta prueba.
            ControladorCategoria controladorCategoria = new ControladorCategoria();
            ControladorEmpleado controladorEmpleado = new ControladorEmpleado();

            DateTime FechaNacimiento = DateTime.ParseExact("06/11/1991", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime FechaInicio = DateTime.ParseExact("01/04/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //Aceptado
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Pablo", "Barragan", FechaNacimiento, 36000000, "Profesor de futbol", FechaInicio, EnumTipoEmpleado.Profesor) > 0);
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Daiana", "Giorgi", FechaNacimiento, 36001111, "Secretaria del departamento de registro", FechaInicio, EnumTipoEmpleado.Secretaria) > 0);
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Leandro", "Long", FechaNacimiento, 36002222, "Directivo seleccionado por el 80 por ciento de los socios", FechaInicio, EnumTipoEmpleado.Directivo) > 0);
            ModelEmpleadoPersona empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36000000);
            Assert.IsNotNull(empleado_buscado);
            Assert.IsTrue(controladorEmpleado.ListarTodosEmpleados().Count > 0);
            Assert.IsTrue(controladorEmpleado.ListarTodosEmpleadosPorFiltro("blo", "", "", "").Count > 0);
            Assert.IsTrue(controladorEmpleado.ListarTodosEmpleadosPorFiltro("", "or", "", "").Count > 0);
            Assert.IsTrue(controladorEmpleado.ListarTodosEmpleadosPorFiltro("", "", "36", "").Count > 0);
            Assert.IsTrue(controladorEmpleado.ListarTodosEmpleadosPorFiltro("", "", "", "Secretaria").Count > 0);
            Assert.IsTrue(controladorEmpleado.ModificarEmpleado(empleado_buscado.MiPersona.IdPersona, empleado_buscado.MiEmpleado.IdEmpleado, "Pablito clavo un clavito", "Clavito clavo un pablito", FechaNacimiento, 36000000, "Se equivoco de profesorado", FechaInicio, EnumTipoEmpleado.Profesor, EnumEstadoEmpleado.Activo) > 0);
            //Error
            Assert.AreEqual(controladorEmpleado.CrearEmpleado("OtraPersona", "OtraPersona", FechaNacimiento, 36000000, "Otro Descrip", FechaInicio, EnumTipoEmpleado.Mantenimiento), -2);
            Assert.IsFalse(controladorEmpleado.ListarTodosEmpleadosPorFiltro("z", "", "", "").Count > 0);
            Assert.IsFalse(controladorEmpleado.ListarTodosEmpleadosPorFiltro("", "z", "", "").Count > 0);
            Assert.IsFalse(controladorEmpleado.ListarTodosEmpleadosPorFiltro("", "", "z", "").Count > 0);
            Assert.IsFalse(controladorEmpleado.ListarTodosEmpleadosPorFiltro("", "", "", "Mantenimiento").Count > 0);
            //Eliminación
            Assert.IsTrue(controladorEmpleado.EliminarEmpleado(empleado_buscado.MiEmpleado) > 0);
            empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36001111);
            Assert.IsTrue(controladorEmpleado.EliminarEmpleado(empleado_buscado.MiEmpleado) > 0);
            empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36002222);
            Assert.IsTrue(controladorEmpleado.EliminarEmpleado(empleado_buscado.MiEmpleado) > 0);
            //Recuperación
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Pablo", "Barragan", FechaNacimiento, 36000000, "Recuperando Profesor de futbol", FechaInicio, EnumTipoEmpleado.Profesor) == -1);
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Daiana", "Giorgi", FechaNacimiento, 36001111, "Recuperando Secretaria del departamento de registro", FechaInicio, EnumTipoEmpleado.Secretaria) == -1);
            Assert.IsTrue(controladorEmpleado.CrearEmpleado("Leandro", "Long", FechaNacimiento, 36002222, "Recuperando Directivo seleccionado por el 80 por ciento de los socios", FechaInicio, EnumTipoEmpleado.Directivo) == -1);
            //Relacion Empleado Categoria
            empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36000000);
            Assert.IsTrue(controladorCategoria.AsignarEmpleadoAlCategoria(empleado_buscado.MiEmpleado, controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) > 0);
            //Error intento de agregar de nuevo
            Assert.IsTrue(controladorCategoria.AsignarEmpleadoAlCategoria(empleado_buscado.MiEmpleado, controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) == -2);
            //Eliminar relacion Empleado Categoria
            empleado_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36000000);
            Assert.IsTrue(controladorCategoria.EliminarEmpleadoDelCategoria(empleado_buscado.MiEmpleado, controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) > 0);
            //Error intento de eliminar de nuevo
            Assert.IsTrue(controladorCategoria.EliminarEmpleadoDelCategoria(empleado_buscado.MiEmpleado, controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) == -2);

            //Registrar Ingreso Empleado
            Assert.IsTrue(controladorEmpleado.RegistrarEntradaSalidaEmpleado(empleado_buscado) == 0);
            //Registrar Salida Empleado
            Assert.IsTrue(controladorEmpleado.RegistrarEntradaSalidaEmpleado(empleado_buscado) == 1);
            //Registrar Ingreso Empleado
            Assert.IsTrue(controladorEmpleado.RegistrarEntradaSalidaEmpleado(empleado_buscado) == 0);

            using (var context = new DiagramasDeTablasContainer1())
            {
                registros.AddRange(context.RegistroIngresoEgresoes
                    .AsEnumerable()
                    .Where(b => b.Empleado.Persona.DNI == 36000000)
                    .ToList());
            }

            //El empleado registró dos veces su ingreso y una sola vez la salida, lo que se crea 2 filas en la tabla
            Assert.IsTrue(registros.Count == 2);

            empleados.Add(controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36000000).MiEmpleado);
            empleados.Add(controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36001111).MiEmpleado);
            empleados.Add(controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36002222).MiEmpleado);
            personas.Add(controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36000000).MiPersona);
            personas.Add(controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36001111).MiPersona);
            personas.Add(controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36002222).MiPersona);
        }


        [Test, Order(4)]
        public void Test5LoginEmpleadoControladorBD()
        {
            // Una vez ejecutada los testings anteriores debieron haber sido creado los nuevos datos antes de continuar con esta prueba.
            ControladorEmpleado controladorEmpleado = new ControladorEmpleado();
            Empleado secretaria_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36001111).MiEmpleado;
            Empleado directivo_buscado = controladorEmpleado.BuscarEmpleadoPorClavesUnicasPorVista(36002222).MiEmpleado;
            Login login1 = new Login() { Empleado = secretaria_buscado, usuario = "dgiorgi", contraseña = "dgiorgi" };
            Login login2 = new Login() { Empleado = directivo_buscado, usuario = "llong", contraseña = "llong" };
            using (var context = new DiagramasDeTablasContainer1()) // Se guarda los nuevos login en la base de datos de manera manual, sin uso de controlador
            {
                context.Entry(secretaria_buscado).State = System.Data.Entity.EntityState.Modified;
                context.Entry(login1).State = System.Data.Entity.EntityState.Added;
                context.Entry(directivo_buscado).State = System.Data.Entity.EntityState.Modified;
                context.Entry(login2).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            //Aceptación
            Assert.IsNotNull(controladorEmpleado.VerificarLoginEmpleado("dgiorgi", "dgiorgi"));
            Assert.IsNotNull(controladorEmpleado.VerificarLoginEmpleado("llong", "llong"));
            //Rechazo
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("dgiorgi", "llong"));
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("llong", "dgiorgi"));
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("xaz", "xaz"));
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("dgiorgi", ""));
            Assert.IsNull(controladorEmpleado.VerificarLoginEmpleado("", "dgiorgi"));

            logins.Add(login1);
            logins.Add(login2);
        }
        [TestCase, Order(5)]
        public void Test6SocioControladorBD()
        {
            // Una vez ejecutada los testings anteriores debieron haber sido creado los nuevos datos antes de continuar con esta prueba.
            ControladorCategoria controladorCategoria = new ControladorCategoria();
            ControladorSocio controladorSocio = new ControladorSocio();

            DateTime FechaNacimiento = DateTime.ParseExact("01/03/1990", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime FechaInicio = DateTime.ParseExact("01/04/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //Sin tener una monto inicial para asociar al Categoria no se puede registrar ningun socio
            Assert.IsTrue(controladorSocio.CrearSocio("Roberto", "Gonzalez", FechaNacimiento, 36110000, "Lavaisse 0000", "Santa Fe", "4564322", EnumTipoDocumento.DNI, EnumCategoriaSocio.Activo) == -3);
            controladorSocio.CrearValorInicialClub(double.Parse("1000"));
            //Aceptado
            Assert.IsTrue(controladorSocio.CrearSocio("Roberto","Gonzalez",FechaNacimiento,36110000,"Lavaisse 0000","Santa Fe","4564322",EnumTipoDocumento.DNI,EnumCategoriaSocio.Activo) > 0);
            Assert.IsTrue(controladorSocio.CrearSocio("Ricardo", "Guitorri", FechaNacimiento, 36111111, "General Lopez 0000", "Rosario", "4774322", EnumTipoDocumento.DNI, EnumCategoriaSocio.Menor) > 0);
            Assert.IsTrue(controladorSocio.CrearSocio("Marcela", "Corault", FechaNacimiento, 36112222, "Primea Junta 0000", "Santa Fe", "4561122", EnumTipoDocumento.DNI, EnumCategoriaSocio.Adherente) > 0);
            ModelSocioPersona socio_buscado = controladorSocio.BuscarPorClavesUnicasSocio(36110000);
            Assert.IsNotNull(socio_buscado);
            Assert.IsTrue(controladorSocio.ListarTodosSocios().Count > 0);
            Assert.IsTrue(controladorSocio.ListarTodosSociosPorFiltro("rto","","").Count > 0);
            Assert.IsTrue(controladorSocio.ListarTodosSociosPorFiltro("", "rau", "").Count > 0);
            Assert.IsTrue(controladorSocio.ListarTodosSociosPorFiltro("", "", "1122").Count > 0);
            //Error
            Assert.AreEqual(controladorSocio.CrearSocio("OtraPersona", "OtraPersona", FechaNacimiento, 36110000, "En la luna", "Planeta Jupiter", "1111111", EnumTipoDocumento.PASAPORTE, EnumCategoriaSocio.Vitalicio), -2);
            Assert.IsFalse(controladorSocio.ListarTodosSociosPorFiltro("z", "", "").Count > 0);
            Assert.IsFalse(controladorSocio.ListarTodosSociosPorFiltro("", "k", "").Count > 0);
            Assert.IsFalse(controladorSocio.ListarTodosSociosPorFiltro("", "", "9").Count > 0);
            //Eliminación
            Assert.IsTrue(controladorSocio.EliminarSocio(socio_buscado.MiSocio) > 0);
            socio_buscado = controladorSocio.BuscarPorClavesUnicasSocio(36111111);
            Assert.IsTrue(controladorSocio.EliminarSocio(socio_buscado.MiSocio) > 0);
            socio_buscado = controladorSocio.BuscarPorClavesUnicasSocio(36112222);
            Assert.IsTrue(controladorSocio.EliminarSocio(socio_buscado.MiSocio) > 0);
            //Recuperación
            Assert.IsTrue(controladorSocio.CrearSocio("Roberto", "Gonzalez", FechaNacimiento, 36110000, "Lavaisse 0000", "Santa Fe", "4564322", EnumTipoDocumento.DNI, EnumCategoriaSocio.Activo) == -1);
            Assert.IsTrue(controladorSocio.CrearSocio("Ricardo", "Guitorri", FechaNacimiento, 36111111, "General Lopez 0000", "Rosario", "4774322", EnumTipoDocumento.DNI, EnumCategoriaSocio.Activo) == -1);
            Assert.IsTrue(controladorSocio.CrearSocio("Marcela", "Corault", FechaNacimiento, 36112222, "Primea Junta 0000", "Santa Fe", "4561122", EnumTipoDocumento.DNI, EnumCategoriaSocio.Activo) == -1);
            //Relacion Socio Categoria
            socio_buscado = controladorSocio.BuscarPorClavesUnicasSocio(36110000);
            Assert.IsTrue(controladorCategoria.InscribirSocioAlCategoria(socio_buscado.MiSocio, controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) > 0);
            //Error intento de inscribir de nuevo
            Assert.IsTrue(controladorCategoria.InscribirSocioAlCategoria(socio_buscado.MiSocio, controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) == -2);
            //Eliminar relacion Socio Categoria
            Assert.IsTrue(controladorCategoria.UnsuscribirSocioAlCategoria(socio_buscado.MiSocio, controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) > 0);
            //Error intento de unsuscribir de nuevo
            Assert.IsTrue(controladorCategoria.UnsuscribirSocioAlCategoria(socio_buscado.MiSocio, controladorCategoria.BuscarCategoriaPorClavesUnicas("FutbolPrueba 2do cuastrimestre 2018")) == -2);

            //La relacion que se establece con un socio y las cuotas generadas
            Assert.IsTrue(controladorSocio.ListarCuotaSocios(socio_buscado.MiSocio).Count > 0);
            CuotaSocio cuotaSocio = controladorSocio.ListarCuotaSocios(socio_buscado.MiSocio)[0].MiCuota;
            Assert.IsTrue(controladorSocio.AnularCuotaSocio(cuotaSocio) > 0);


            socios.Add(controladorSocio.BuscarPorClavesUnicasSocio(36110000).MiSocio);
            socios.Add(controladorSocio.BuscarPorClavesUnicasSocio(36111111).MiSocio);
            socios.Add(controladorSocio.BuscarPorClavesUnicasSocio(36112222).MiSocio);

            personas.Add(controladorSocio.BuscarPorClavesUnicasSocio(36110000).MiPersona);
            personas.Add(controladorSocio.BuscarPorClavesUnicasSocio(36111111).MiPersona);
            personas.Add(controladorSocio.BuscarPorClavesUnicasSocio(36112222).MiPersona);

            using (var context = new DiagramasDeTablasContainer1())
            {
                cuotassocios.AddRange(context.CuotaSocios
                    .AsEnumerable()
                    .Where(b => b.Socio.Persona.DNI == 36110000 || b.Socio.Persona.DNI == 36111111 || b.Socio.Persona.DNI == 36112222)
                    .ToList());
                
            }
            cuotasiniciales.Add(controladorSocio.UltimoValorInicialClub());

        }



        [OneTimeTearDown]
        public void Limpieza() //Esta función limpia todo al terminar de probar todas las pruebas
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
             
                
                context.Deportes.RemoveRange(context.Deportes.AsEnumerable().Where(b => deportes.Select(s => s.IdDeporte).Contains(b.IdDeporte)).ToList());
                context.Categorias.RemoveRange(context.Categorias.AsEnumerable().Where(b => categorias.Select(s => s.IdCategoria).Contains(b.IdCategoria)).ToList());
                context.Empleados.RemoveRange(context.Empleados.AsEnumerable().Where(b => empleados.Select(s => s.IdEmpleado).Contains(b.IdEmpleado)).ToList());
                context.CuotaSocios.RemoveRange(context.CuotaSocios.AsEnumerable().Where(b => cuotassocios.Select(s => s.IdCuota).Contains(b.IdCuota)).ToList());
                context.ValorCuotaInicials.RemoveRange(context.ValorCuotaInicials.AsEnumerable().Where(b => cuotasiniciales.Select(s => s.IdCuotaInicial).Contains(b.IdCuotaInicial)).ToList());
                context.Logins.RemoveRange(context.Logins.AsEnumerable().Where(b => logins.Select(s => s.IdLogin).Contains(b.IdLogin)).ToList());
                context.Personas.RemoveRange(context.Personas.AsEnumerable().Where(b => personas.Select(s => s.IdPersona).Contains(b.IdPersona)).ToList());
                context.RegistroIngresoEgresoes.RemoveRange(context.RegistroIngresoEgresoes.AsEnumerable().Where(b => registros.Select(s => s.IdRegistro).Contains(b.IdRegistro)).ToList());
                context.Socios.RemoveRange(context.Socios.AsEnumerable().Where(b => socios.Select(s => s.IdSocio).Contains(b.IdSocio)).ToList());
               
                context.SaveChanges();
            }
        }
    }
}
