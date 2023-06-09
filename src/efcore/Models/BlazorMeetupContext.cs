﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace efcore.Models
{
    public partial class BlazorMeetupContext : DbContext
    {
        public BlazorMeetupContext()
        {
        }

        public BlazorMeetupContext(DbContextOptions<BlazorMeetupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.DbId);

                entity.Property(e => e.DbId).HasComment("일련번호");

                entity.Property(e => e.Age).HasComment("나이");

                entity.Property(e => e.MailAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("이메일주소");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("이름");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}