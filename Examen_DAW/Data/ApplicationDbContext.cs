﻿using Examen_DAW.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Examen.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<EventParticipant> EventParticipants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventParticipant>()
                .HasKey(ep => new { ep.EventId, ep.ParticipantId });

            modelBuilder.Entity<EventParticipant>()
                .HasOne(ep => ep.Event)
                .WithMany(e => e.EventParticipants)
                .HasForeignKey(ep => ep.EventId);

            modelBuilder.Entity<EventParticipant>()
                .HasOne(ep => ep.Participant)
                .WithMany(p => p.EventParticipants)
                .HasForeignKey(ep => ep.ParticipantId);
        }
    }
}