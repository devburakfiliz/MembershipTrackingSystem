using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Helpers.FileHelper;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MemberManager>().As<IMemberService>().SingleInstance();
            builder.RegisterType<EfMemberDal>().As<IMemberDal>().SingleInstance();

            builder.RegisterType<MounthlyPaymentManager>().As<IMounthlyPaymentService>().SingleInstance();
            builder.RegisterType<EfMountlyPaymentDal>().As<IMonthlyPaymentDal>().SingleInstance();

            builder.RegisterType<FileHelperManager>().As<IFileHelper>().SingleInstance();

            builder.RegisterType<ImageHelperManager>().As<IImagesHelper>().SingleInstance();

        }
    }
}