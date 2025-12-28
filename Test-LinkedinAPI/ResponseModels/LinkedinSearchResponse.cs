using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Test_LinkedinAPI.ResponseModels
{
    public class LinkedinSearchResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("config")]
        public Config Config { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AdvancedKeywords
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }
    }

    public class Analytics
    {
        [JsonProperty("impressions")]
        public int Impressions { get; set; }

        [JsonProperty("engagements")]
        public int Engagements { get; set; }

        [JsonProperty("engagement_rate")]
        public int EngagementRate { get; set; }

        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("clickthrough_rate")]
        public int ClickthroughRate { get; set; }

        [JsonProperty("page_viewers_from_this_post")]
        public int PageViewersFromThisPost { get; set; }

        [JsonProperty("followers_gained_from_this_post")]
        public int FollowersGainedFromThisPost { get; set; }

        [JsonProperty("members_reached")]
        public int MembersReached { get; set; }
    }

    public class Attachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }

        [JsonProperty("mimetype")]
        public string Mimetype { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("url_expires_at")]
        public int UrlExpiresAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public Size Size { get; set; }

        [JsonProperty("sticker")]
        public bool Sticker { get; set; }

        [JsonProperty("gif")]
        public bool? Gif { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("voice_note")]
        public bool? VoiceNote { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("starts_at")]
        public int? StartsAt { get; set; }

        [JsonProperty("expires_at")]
        public int? ExpiresAt { get; set; }

        [JsonProperty("time_range")]
        public int? TimeRange { get; set; }
    }

    public class Author
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("seat_id")]
        public string SeatId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("public_profile_url")]
        public bool PublicProfileUrl { get; set; }

        [JsonProperty("public_identifier")]
        public string PublicIdentifier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_company")]
        public bool IsCompany { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }
    }

    public class Certification
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("start")]
        public Start Start { get; set; }

        [JsonProperty("end")]
        public End End { get; set; }
    }

    public class Company
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("public_identifier")]
        public string PublicIdentifier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("profile_picture_url")]
        public string ProfilePictureUrl { get; set; }
    }

    public class CompanyHeadcount
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class Config
    {
        [JsonProperty("params")]
        public Params Params { get; set; }
    }

    public class CurrentPosition
    {
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("company_url")]
        public string CompanyUrl { get; set; }

        [JsonProperty("company_description")]
        public string CompanyDescription { get; set; }

        [JsonProperty("company_headcount")]
        public CompanyHeadcount CompanyHeadcount { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("industry")]
        public List<string> Industry { get; set; }

        [JsonProperty("tenure_at_role")]
        public TenureAtRole TenureAtRole { get; set; }

        [JsonProperty("tenure_at_company")]
        public TenureAtCompany TenureAtCompany { get; set; }

        [JsonProperty("start")]
        public Start Start { get; set; }

        [JsonProperty("end")]
        public End End { get; set; }

        [JsonProperty("skills")]
        public List<Skill> Skills { get; set; }
    }

    public class Education
    {
        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("field_of_study")]
        public string FieldOfStudy { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("school_id")]
        public string SchoolId { get; set; }

        [JsonProperty("start")]
        public Start Start { get; set; }

        [JsonProperty("end")]
        public End End { get; set; }

        [JsonProperty("school_details")]
        public SchoolDetails SchoolDetails { get; set; }
    }

    public class End
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }
    }

    public class Group
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }
    }

    public class Item
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("public_identifier")]
        public string PublicIdentifier { get; set; }

        [JsonProperty("public_profile_url")]
        public string PublicProfileUrl { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("profile_picture_url")]
        public string ProfilePictureUrl { get; set; }

        [JsonProperty("profile_picture_url_large")]
        public string ProfilePictureUrlLarge { get; set; }

        [JsonProperty("member_urn")]
        public string MemberUrn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("network_distance")]
        public string NetworkDistance { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("keywords_match")]
        public string KeywordsMatch { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("connections_count")]
        public int ConnectionsCount { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("pending_invitation")]
        public bool PendingInvitation { get; set; }

        [JsonProperty("can_send_inmail")]
        public bool CanSendInmail { get; set; }

        [JsonProperty("hiddenCandidate")]
        public bool HiddenCandidate { get; set; }

        [JsonProperty("interestLikelihood")]
        public string InterestLikelihood { get; set; }

        [JsonProperty("privacySettings")]
        public PrivacySettings PrivacySettings { get; set; }

        [JsonProperty("skills")]
        public List<Skill> Skills { get; set; }

        [JsonProperty("recruiter_candidate_id")]
        public string RecruiterCandidateId { get; set; }

        [JsonProperty("recruiter_pipeline_category")]
        public string RecruiterPipelineCategory { get; set; }

        [JsonProperty("premium")]
        public bool Premium { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("open_profile")]
        public bool OpenProfile { get; set; }

        [JsonProperty("shared_connections_count")]
        public int SharedConnectionsCount { get; set; }

        [JsonProperty("recent_posts_count")]
        public int RecentPostsCount { get; set; }

        [JsonProperty("recently_hired")]
        public bool RecentlyHired { get; set; }

        [JsonProperty("mentioned_in_the_news")]
        public bool MentionedInTheNews { get; set; }

        [JsonProperty("last_outreach_activity")]
        public LastOutreachActivity LastOutreachActivity { get; set; }

        [JsonProperty("current_positions")]
        public List<CurrentPosition> CurrentPositions { get; set; }

        [JsonProperty("education")]
        public List<Education> Education { get; set; }

        [JsonProperty("work_experience")]
        public List<WorkExperience> WorkExperience { get; set; }

        [JsonProperty("certifications")]
        public List<Certification> Certifications { get; set; }

        [JsonProperty("projects")]
        public List<Project> Projects { get; set; }

        [JsonProperty("interests")]
        public string Interests { get; set; }

        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }

        [JsonProperty("notes")]
        public List<Note> Notes { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("job_offers_count")]
        public int? JobOffersCount { get; set; }

        [JsonProperty("headcount")]
        public string Headcount { get; set; }

        [JsonProperty("revenue_range")]
        public RevenueRange RevenueRange { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("social_id")]
        public string SocialId { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("parsed_datetime")]
        public string ParsedDatetime { get; set; }

        [JsonProperty("reaction_counter")]
        public int? ReactionCounter { get; set; }

        [JsonProperty("comment_counter")]
        public int? CommentCounter { get; set; }

        [JsonProperty("repost_counter")]
        public int? RepostCounter { get; set; }

        [JsonProperty("impressions_counter")]
        public int? ImpressionsCounter { get; set; }

        [JsonProperty("user_reacted")]
        public string UserReacted { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("written_by")]
        public WrittenBy WrittenBy { get; set; }

        [JsonProperty("permissions")]
        public Permissions Permissions { get; set; }

        [JsonProperty("is_repost")]
        public bool? IsRepost { get; set; }

        [JsonProperty("repost_id")]
        public string RepostId { get; set; }

        [JsonProperty("reposted_by")]
        public RepostedBy RepostedBy { get; set; }

        [JsonProperty("repost_content")]
        public RepostContent RepostContent { get; set; }

        [JsonProperty("mentions")]
        public List<Mention> Mentions { get; set; }

        [JsonProperty("attachments")]
        public List<Attachment> Attachments { get; set; }

        [JsonProperty("poll")]
        public Poll Poll { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("analytics")]
        public Analytics Analytics { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("posted_at")]
        public DateTime? PostedAt { get; set; }

        [JsonProperty("reposted")]
        public bool? Reposted { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("promoted")]
        public bool? Promoted { get; set; }

        [JsonProperty("benefits")]
        public List<string> Benefits { get; set; }

        [JsonProperty("easy_apply")]
        public bool? EasyApply { get; set; }

        [JsonProperty("company")]
        public Company? Company { get; set; }
    }

    public class LastOutreachActivity
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("performed_at")]
        public string PerformedAt { get; set; }
    }

    public class Mention
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }

    public class Note
    {
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }
    }

    public class Option
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("win")]
        public bool Win { get; set; }

        [JsonProperty("votes_count")]
        public int VotesCount { get; set; }
    }

    public class Paging
    {
        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("page_count")]
        public int PageCount { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class Params
    {
        [JsonProperty("api")]
        public string Api { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        [JsonProperty("industry")]
        public List<string> Industry { get; set; }

        [JsonProperty("location")]
        public List<string> Location { get; set; }

        [JsonProperty("profile_language")]
        public List<string> ProfileLanguage { get; set; }

        [JsonProperty("network_distance")]
        public List<int> NetworkDistance { get; set; }

        [JsonProperty("company")]
        public List<string> Company { get; set; }

        [JsonProperty("past_company")]
        public List<string> PastCompany { get; set; }

        [JsonProperty("school")]
        public List<string> School { get; set; }

        [JsonProperty("service")]
        public List<string> Service { get; set; }

        [JsonProperty("connections_of")]
        public List<string> ConnectionsOf { get; set; }

        [JsonProperty("followers_of")]
        public List<string> FollowersOf { get; set; }

        [JsonProperty("open_to")]
        public List<string> OpenTo { get; set; }

        [JsonProperty("advanced_keywords")]
        public AdvancedKeywords AdvancedKeywords { get; set; }
    }

    public class Permissions
    {
        [JsonProperty("can_react")]
        public bool CanReact { get; set; }

        [JsonProperty("can_share")]
        public bool CanShare { get; set; }

        [JsonProperty("can_post_comments")]
        public bool CanPostComments { get; set; }
    }

    public class Poll
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("total_votes_count")]
        public int TotalVotesCount { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("is_open")]
        public bool IsOpen { get; set; }

        [JsonProperty("options")]
        public List<Option> Options { get; set; }
    }

    public class PrivacySettings
    {
        [JsonProperty("allowConnectionsBrowse")]
        public bool AllowConnectionsBrowse { get; set; }

        [JsonProperty("showPremiumSubscriberIcon")]
        public bool ShowPremiumSubscriberIcon { get; set; }
    }

    public class Project
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("skills")]
        public List<string> Skills { get; set; }

        [JsonProperty("start")]
        public Start Start { get; set; }

        [JsonProperty("end")]
        public End End { get; set; }
    }

    public class RepostContent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("parsed_datetime")]
        public string ParsedDatetime { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class RepostedBy
    {
        [JsonProperty("public_identifier")]
        public string PublicIdentifier { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_company")]
        public bool IsCompany { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }
    }

    public class RevenueRange
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }    

    public class SchoolDetails
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("employeeCount")]
        public int EmployeeCount { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }

    public class Size
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class Skill
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("endorsement_count")]
        public int EndorsementCount { get; set; }
    }

    public class Start
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }
    }

    public class Tag
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TenureAtCompany
    {
        [JsonProperty("years")]
        public int Years { get; set; }

        [JsonProperty("months")]
        public int Months { get; set; }
    }

    public class TenureAtRole
    {
        [JsonProperty("years")]
        public int Years { get; set; }

        [JsonProperty("months")]
        public int Months { get; set; }
    }

    public class WorkExperience
    {
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("company_url")]
        public string CompanyUrl { get; set; }

        [JsonProperty("company_description")]
        public string CompanyDescription { get; set; }

        [JsonProperty("company_headcount")]
        public CompanyHeadcount CompanyHeadcount { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start")]
        public Start Start { get; set; }

        [JsonProperty("end")]
        public End End { get; set; }

        [JsonProperty("skills")]
        public List<Skill> Skills { get; set; }
    }

    public class WrittenBy
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("public_identifier")]
        public string PublicIdentifier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }


}
