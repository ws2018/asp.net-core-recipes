using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Database Context
    /// </summary>
    public sealed class MoBContext : DbContext
    {
        /// <summary>
        /// Constructor accepts DbContextOptions which is passed to base constructor
        /// Use this constructor  with your ASP.NET Core application
        /// </summary>
        /// <param name="options"></param>
        public MoBContext(DbContextOptions<MoBContext> options)
            : base(options) { }

        /// <summary>
        /// Constructor allows connection string to be injected
        /// </summary>
        public MoBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        private string _connectionString = null;

        /// <summary>
        /// Default constructor can be used with Unit Tests
        /// </summary>
        public MoBContext() { }

        // note for EF Core, the name defined here is used as the DB table name
        // EF Core does not allow you to change the pluralization conventions

        /// <summary>
        /// Tracks alerts generated by the system
        /// </summary>
        public DbSet<Alert> Alerts { get; set; } // Alert

        /// <summary>
        /// Contains data regarding members subscriptions to alerts
        /// </summary>
        public DbSet<AlertSubscription> AlertSubscriptions { get; set; } // AlertSubscription

        /// <summary>
        /// Creates relationship between alerts and tags allowing functionality such as member subscribing to tag
        /// </summary>
        public DbSet<AlertTag> AlertTags { get; set; } // AlertTag

        /// <summary>
        /// Contain information regarding web site users who participate in music collaborations
        /// </summary>
        public DbSet<Artist> Artists { get; set; } // Artist

        /// <summary>
        /// Shows relationship between artist and band
        /// </summary>
        public DbSet<ArtistBand> ArtistBands { get; set; } // ArtistBand

        /// <summary>
        /// Used to allow artist to block other artists from contacting them
        /// </summary>
        public DbSet<ArtistBlock> ArtistBlocks { get; set; } // ArtistBlock

        /// <summary>
        /// Shows relationship between an artist and 
        /// </summary>
        public DbSet<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; } // ArtistCollaborationSpaces

        /// <summary>
        /// Stores favorite songs, collaboration spaces, and artists for a user
        /// </summary>
        public DbSet<ArtistFavorite> ArtistFavorites { get; set; } // ArtistFavorites

        /// <summary>
        /// Defines layout of artist profile page
        /// </summary>
        public DbSet<ArtistProfile> ArtistProfiles { get; set; } // ArtistProfile

        /// <summary>
        /// Tracks skills and level of proficiency in that skill
        /// </summary>
        public DbSet<ArtistSkill> ArtistSkills { get; set; } // ArtistSkill

        /// <summary>
        /// List of bands. 
        /// </summary>
        public DbSet<Band> Bands { get; set; } // Band

        /// <summary>
        /// Tracks band audition work flow
        /// </summary>
        public DbSet<BandAudition> BandAuditions { get; set; } // BandAudition

        /// <summary>
        /// Comments posted by band members regarding an audition
        /// </summary>
        public DbSet<BandAuditionComment> BandAuditionComments { get; set; } // BandAuditionComment

        /// <summary>
        /// The genre a bands is associated with
        /// </summary>
        public DbSet<BandGenre> BandGenres { get; set; } // BandGenre

        /// <summary>
        /// Email addresses that are banned from registering on the site
        /// </summary>
        public DbSet<BannedEmailAddress> BannedEmailAddresses { get; set; } // BannedEmailAddress

        /// <summary>
        /// Collaboration Spaces that can be used for groups of artists to work on songs
        /// </summary>
        public DbSet<CollaborationSpace> CollaborationSpaces { get; set; } // CollaborationSpace

        /// <summary>
        /// Alerts from actions taken on a collaboration space
        /// </summary>
        public DbSet<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; } // CollaborationSpaceAlerts

        /// <summary>
        /// Comments posted in a collaboration space
        /// </summary>
        public DbSet<CollaborationSpaceComment> CollaborationSpaceComments { get; set; } // CollaborationSpaceComment

        /// <summary>
        /// Files posted to a collaboration space
        /// </summary>
        public DbSet<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; } // CollaborationSpaceFile

        /// <summary>
        /// The type of music that will be created in the collaboration space
        /// </summary>
        public DbSet<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; } // CollaborationSpaceGenre

        /// <summary>
        /// Tracks invitations to a collaboration space
        /// </summary>
        public DbSet<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; } // CollaborationSpaceInvite

        /// <summary>
        /// Shows relationship between Media and collaboration spaces
        /// </summary>
        public DbSet<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; } // CollaborationSpaceMedia

        /// <summary>
        /// Allows people to opt-out of emails from the web site
        /// </summary>
        public DbSet<EmailOptOut> EmailOptOuts { get; set; } // EmailOptOut

        /// <summary>
        /// Tracks email verification work flow for new registrations
        /// </summary>
        public DbSet<EmailVerification> EmailVerifications { get; set; } // EmailVerification

        /// <summary>
        /// Lookup list for Genre
        /// </summary>
        public DbSet<GenreLookUp> GenreLookUps { get; set; } // GenreLookUp

        /// <summary>
        /// Meta-data about files uploaded to the site
        /// </summary>
        public DbSet<Media> Media { get; set; } // Media

        /// <summary>
        /// Personal message between members
        /// </summary>
        public DbSet<Message> Messages { get; set; } // Message

        /// <summary>
        /// Site members who message will be sent to
        /// </summary>
        public DbSet<MessageRecipient> MessageRecipients { get; set; } // MessageRecipient

        /// <summary>
        /// Personal messages marked as Spam
        /// </summary>
        public DbSet<MessageSpam> MessageSpams { get; set; } // MessageSpam

        /// <summary>
        /// Stores job opening for bands and collaboration spaces
        /// </summary>
        public DbSet<OpenPosition> OpenPositions { get; set; } // OpenPosition

        /// <summary>
        /// A play list of songs 
        /// </summary>
        public DbSet<PlayList> PlayLists { get; set; } // PlayList

        /// <summary>
        /// Describes songs in a play list
        /// </summary>
        public DbSet<PlaylistItem> PlaylistItems { get; set; } // PlaylistItem

        /// <summary>
        /// Contains meta-data for songs uploaded to the site or published from completed collaborations
        /// </summary>
        public DbSet<Song> Songs { get; set; } // Song

        /// <summary>
        /// Contains comments about songs posted by fans
        /// </summary>
        public DbSet<SongComment> SongComments { get; set; } // SongComment

        /// <summary>
        /// Contains work items assigned to user from work flows such as the band approval work flow
        /// </summary>
        public DbSet<Task> Tasks { get; set; } // Task



        /// <summary>
        /// Code that runs when model is created. Used to add meta-data 
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            // also has a property called Id, EF can't figure out which one to use
            builder.Entity<Artist>().HasKey(a => a.ArtistId);
            builder.Entity<Artist>().Ignore(a => a.Id);

            // These are computed fields that are not present in the database
            builder.Entity<Artist>().Ignore(a => a.AvatarUrlSample);

            // Many to many relationships that could not be determined automatically
            builder.Entity<ArtistProfile>().HasKey(a => a.ArtistId);

            //does not match the convention so need to add custom primary key
            builder.Entity<ArtistSkill>().HasKey(a => a.ArtistTalentId);
            builder.Entity<BannedEmailAddress>().HasKey(a => a.EmailAddress);
            builder.Entity<EmailOptOut>().HasKey(a => a.EmailAddress);

            base.OnModelCreating(builder);
        }

        /// <summary>
        /// Allows configuration information to be passed to DB Context.
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(_connectionString==null)
            {
                base.OnConfiguring(options);
            }
            else
            {
                options.UseSqlServer(_connectionString);
            }
            

        }

        

    }
}