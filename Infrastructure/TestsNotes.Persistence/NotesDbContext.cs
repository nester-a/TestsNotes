﻿using Microsoft.EntityFrameworkCore;
using TestsNotes.Application.Interfaces;
using TestsNotes.Domain;
using TestsNotes.Persistence.EntityTypeConfiguration;

namespace TestsNotes.Persistence
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
