using System;
using System.IO;
using System.CodeDom.Compiler;

using Google.Apis;
using Google.Apis.Tools.CodeGen;

using Google.Apis.Discovery;

namespace Google.Apis.Samples.ComandLineServiceGenerator
{
	class MainClass
	{
		public static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MainClass));
		
		#region buzz discovery 0.3
        public const string BuzzV0_3_Json = @"{
 'name': 'buzz',
 'version': 'v1',
 'description': 'Buzz APIs for Buzz Posts, etc.',
 'restBasePath': '/buzz/v1/',
 'rpcPath': '/rpc',
 'features': [
  'dataWrapper'
 ],
 'schemas': {
  'Activitiylist': '{\'id\':\'Activitiylist\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'items\':{\'items\':{\'$ref\':\'ChiliActivitiesResourceJson\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#activityFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliActivitiesCountJson': '{\'id\':\'ChiliActivitiesCountJson\',\'properties\':{\'counts\':{\'additionalProperties\':{\'items\':{\'properties\':{\'timestamp\':{\'type\':\'string\'},\'count\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#countFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliActivitiesExtractpeoplefromsearchJson': '{\'id\':\'ChiliActivitiesExtractpeoplefromsearchJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliActivitiesListJson': '{\'id\':\'ChiliActivitiesListJson\',\'$ref\':\'Activitiylist\'}',
  'ChiliActivitiesResourceJson': '{\'id\':\'ChiliActivitiesResourceJson\',\'properties\':{\'visibility\':{\'properties\':{\'entries\':{\'items\':{\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'}},\'type\':\'object\'},\'placeholder\':{\'type\':\'any\'},\'targetLang\':{\'type\':\'any\'},\'placeName\':{\'type\':\'any\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'properties\':{\'liked\':{\'items\':{\'properties\':{\'count\':{\'type\':\'integer\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'}},\'type\':\'object\'},\'crosspostSource\':{\'type\':\'any\'},\'actor\':{\'properties\':{\'id\':{\'type\':\'any\'},\'profileUrl\':{\'type\':\'any\'},\'thumbnailUrl\':{\'type\':\'any\'},\'name\':{\'type\':\'any\'}},\'type\':\'object\'},\'object\':{\'properties\':{\'untranslatedContent\':{\'type\':\'any\'},\'targetLang\':{\'type\':\'any\'},\'liked\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'actor\':{\'properties\':{\'id\':{\'type\':\'any\'},\'profileUrl\':{\'type\':\'any\'},\'thumbnailUrl\':{\'type\':\'any\'},\'name\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':{\'type\':\'string\'},\'detectedlLang\':{\'type\':\'any\'},\'shareOriginal\':{\'$ref\':\'ChiliActivitiesResourceJson\'},\'originalContent\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'content\':{\'type\':\'any\'},\'attachments\':{\'items\':{\'properties\':{\'content\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'type\':{\'type\':\'string\'}},\'type\':\'object\'},\'type\':\'array\'},\'comments\':{\'items\':{\'$ref\':\'ChiliCommentsResourceJson\'},\'type\':\'array\'}},\'type\':\'object\'},\'detectedlLang\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#activity\',\'type\':\'string\'},\'geocode\':{\'type\':\'any\'},\'annotation\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'source\':{\'properties\':{\'title\':{\'type\':\'any\'}},\'type\':\'object\'},\'placeId\':{\'type\':\'any\'},\'address\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'verbs\':{\'items\':{\'type\':\'string\'},\'type\':\'array\'},\'radius\':{\'type\':\'any\'},\'categories\':{\'items\':{\'properties\':{\'schema\':{\'type\':\'any\'},\'term\':{\'type\':\'any\'},\'label\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'untranslatedTitle\':{\'type\':\'any\'},\'published\':{\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliActivitiesSearchJson': '{\'id\':\'ChiliActivitiesSearchJson\',\'$ref\':\'Activitiylist\'}',
  'ChiliActivitiesTrackJson': '{\'id\':\'ChiliActivitiesTrackJson\',\'$ref\':\'Activitiylist\'}',
  'ChiliCommentsListJson': '{\'id\':\'ChiliCommentsListJson\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'items\':{\'items\':{\'$ref\':\'ChiliCommentsResourceJson\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#commentFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliCommentsResourceJson': '{\'id\':\'ChiliCommentsResourceJson\',\'properties\':{\'content\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'detectedLang\':{\'type\':\'any\'},\'untranslatedContent\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'targetLang\':{\'type\':\'any\'},\'placeholder\':{\'type\':\'any\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'properties\':{\'inReplyTo\':{\'items\':{\'properties\':{\'ref\':{\'type\':\'any\'},\'source\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'}},\'type\':\'object\'},\'actor\':{\'properties\':{\'id\':{\'type\':\'any\'},\'profileUrl\':{\'type\':\'any\'},\'thumbnailUrl\':{\'type\':\'any\'},\'name\':{\'type\':\'any\'}},\'type\':\'object\'},\'published\':{\'type\':\'string\'},\'kind\':{\'default\':\'buzz#comment\',\'type\':\'string\'},\'originalContent\':{\'type\':\'any\'}},\'type\':\'object\'}',
  'ChiliEntitiesListJson': '{\'id\':\'ChiliEntitiesListJson\',\'properties\':{\'entry\':{\'items\':{\'$ref\':\'ChiliEntitiesStarredResource\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#starredEntityFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliEntitiesStarredAddJson': '{\'id\':\'ChiliEntitiesStarredAddJson\',\'$ref\':\'ChiliEntitiesStarredResource\'}',
  'ChiliEntitiesStarredListJson': '{\'id\':\'ChiliEntitiesStarredListJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliEntitiesStarredResource\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#starredEntityFeedForUser\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliEntitiesStarredResource': '{\'id\':\'ChiliEntitiesStarredResource\',\'properties\':{\'summary\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'viewerStarAcl\':{\'items\':{\'properties\':{\'id\':{\'type\':\'any\'},\'tags\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'displayName\':{\'type\':\'any\'},\'kind\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'title\':{\'type\':\'any\'},\'chipsUiAcl\':{\'type\':\'any\'},\'totalNumStars\':{\'type\':\'any\'},\'starredBy\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'starredByViewer\':{\'type\':\'any\'},\'comment\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#entity\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliEntitiesdefaultaclResourceJson': '{\'id\':\'ChiliEntitiesdefaultaclResourceJson\',\'properties\':{\'viewerStarAcl\':{\'items\':{\'properties\':{\'id\':{\'type\':\'string\'},\'tags\':{\'items\':{\'type\':\'string\'},\'type\':\'array\'},\'displayName\':{\'type\':\'string\'},\'kind\':{\'type\':\'string\'}},\'type\':\'object\'},\'type\':\'array\'},\'chipsUiAcl\':{\'type\':\'string\'},\'kind\':{\'default\':\'buzz#entityAcl\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliGroupsListJson': '{\'id\':\'ChiliGroupsListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliGroupsResourceJson\'},\'type\':\'array\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#groupFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliGroupsResourceJson': '{\'id\':\'ChiliGroupsResourceJson\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'links\':{\'properties\':{\'self\':{\'items\':{\'properties\':{\'type\':{\'default\':\'application/json\',\'type\':\'string\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'}},\'type\':\'object\'},\'memberCount\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#group\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPeopleLikedJson': '{\'id\':\'ChiliPeopleLikedJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPeopleListJson': '{\'id\':\'ChiliPeopleListJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPeopleResharedJson': '{\'id\':\'ChiliPeopleResharedJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPeopleResourceJson': '{\'id\':\'ChiliPeopleResourceJson\',\'properties\':{\'turnOffs\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'heroes\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'ims\':{\'items\':{\'properties\':{\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'connected\':{\'type\':\'any\'},\'sports\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'languagesSpoken\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'religion\':{\'type\':\'any\'},\'turnOns\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'languages\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'cars\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'pets\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'gender\':{\'type\':\'any\'},\'humor\':{\'type\':\'any\'},\'activities\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'preferredUsername\':{\'type\':\'any\'},\'hasApp\':{\'type\':\'any\'},\'books\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'happiestWhen\':{\'type\':\'any\'},\'scaredOf\':{\'type\':\'any\'},\'nickname\':{\'type\':\'any\'},\'status\':{\'type\':\'any\'},\'emails\':{\'items\':{\'properties\':{\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'profileUrl\':{\'type\':\'any\'},\'food\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'utcOffset\':{\'type\':\'any\'},\'profileVideo\':{\'type\':\'any\'},\'smoker\':{\'type\':\'any\'},\'addresses\':{\'items\':{\'properties\':{\'region\':{\'type\':\'any\'},\'streetAddress\':{\'type\':\'any\'},\'formatted\':{\'type\':\'any\'},\'postalCode\':{\'type\':\'any\'},\'primary\':{\'type\':\'any\'},\'locality\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'country\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'birthday\':{\'type\':\'any\'},\'fashion\':{\'type\':\'any\'},\'interests\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'drinker\':{\'type\':\'any\'},\'movies\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'jobInterests\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'children\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'lookingFor\':{\'type\':\'any\'},\'romance\':{\'type\':\'any\'},\'aboutMe\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#person\',\'type\':\'string\'},\'bodyType\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'tvShows\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'name\':{\'properties\':{\'middleName\':{\'type\':\'any\'},\'formatted\':{\'type\':\'any\'},\'honorificPrefix\':{\'type\':\'any\'},\'familyName\':{\'type\':\'any\'},\'givenName\':{\'type\':\'any\'},\'honorificSuffix\':{\'type\':\'any\'}},\'type\':\'object\'},\'thumbnailUrl\':{\'type\':\'any\'},\'published\':{\'type\':\'string\'},\'relationships\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'profileSong\':{\'type\':\'any\'},\'note\':{\'type\':\'any\'},\'music\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'tags\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'anniversary\':{\'type\':\'any\'},\'politicalViews\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'accounts\':{\'items\':{\'properties\':{\'username\':{\'type\':\'any\'},\'userid\':{\'type\':\'any\'},\'domain\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'urls\':{\'items\':{\'properties\':{\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'organizations\':{\'items\':{\'properties\':{\'startDate\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'location\':{\'type\':\'any\'},\'description\':{\'type\':\'any\'},\'department\':{\'type\':\'any\'},\'primary\':{\'type\':\'any\'},\'name\':{\'type\':\'any\'},\'endDate\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'relationshipStatus\':{\'type\':\'any\'},\'phoneNumbers\':{\'items\':{\'properties\':{\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'livingArrangement\':{\'type\':\'any\'},\'currentLocation\':{\'type\':\'any\'},\'photos\':{\'items\':{\'properties\':{\'height\':{\'type\':\'any\'},\'width\':{\'type\':\'any\'},\'primary\':{\'type\':\'any\'},\'value\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'quotes\':{\'items\':{\'type\':\'any\'},\'type\':\'array\'},\'sexualOrientation\':{\'type\':\'any\'},\'displayName\':{\'type\':\'any\'},\'ethnicity\':{\'type\':\'any\'}},\'type\':\'object\'}',
  'ChiliPeopleSearchJson': '{\'id\':\'ChiliPeopleSearchJson\',\'properties\':{\'startIndex\':{\'type\':\'any\'},\'totalResults\':{\'type\':\'any\'},\'entry\':{\'items\':{\'$ref\':\'ChiliPeopleResourceJson\'},\'type\':\'array\'},\'itemsPerPage\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#peopleFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPhotoalbumsListJson': '{\'id\':\'ChiliPhotoalbumsListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliPhotoalbumsResourceJson\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#albumsFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPhotoalbumsResourceJson': '{\'id\':\'ChiliPhotoalbumsResourceJson\',\'properties\':{\'tags\':{\'items\':{\'type\':\'string\'},\'type\':\'array\'},\'id\':{\'type\':\'integer\'},\'firstPhotoId\':{\'type\':\'integer\'},\'title\':{\'type\':\'string\'},\'lastModified\':{\'type\':\'string\'},\'created\':{\'type\':\'string\'},\'description\':{\'type\':\'string\'},\'owner\':{\'properties\':{\'id\':{\'type\':\'string\'},\'profileUrl\':{\'type\':\'string\'},\'thumbnailUrl\':{\'type\':\'string\'},\'name\':{\'type\':\'string\'}},\'type\':\'object\'},\'links\':{\'properties\':{\'alternate\':{\'$ref\':\'Link\'},\'enclosure\':{\'$ref\':\'Link\'}},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#album\',\'type\':\'string\'},\'version\':{\'type\':\'integer\'}},\'type\':\'object\'}',
  'ChiliPhotosInsertJson': '{\'id\':\'ChiliPhotosInsertJson\',\'properties\':{\'collection\':{\'properties\':{\'albumId\':{\'type\':\'any\'},\'album\':{\'type\':\'any\'},\'photo\':{\'properties\':{\'photoUrl\':{\'type\':\'any\'}},\'type\':\'object\'}},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#album\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPhotosListJson': '{\'id\':\'ChiliPhotosListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliPhotosResourceJson\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#photosFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliPhotosResourceJson': '{\'id\':\'ChiliPhotosResourceJson\',\'properties\':{\'lastModified\':{\'type\':\'string\'},\'album\':{\'properties\':{\'id\':{\'type\':\'integer\'},\'page_link\':{\'$ref\':\'Link\'}},\'type\':\'object\'},\'links\':{\'additionalProperties\':{\'items\':{\'$ref\':\'Link\'},\'type\':\'array\'},\'properties\':{\'alternate\':{\'items\':{\'$ref\':\'Link\'},\'type\':\'array\'}},\'type\':\'object\'},\'kind\':{\'type\':\'string\'},\'version\':{\'type\':\'integer\'},\'id\':{\'type\':\'integer\'},\'timestamp\':{\'type\':\'number\'},\'fileSize\':{\'type\':\'integer\'},\'title\':{\'type\':\'string\'},\'created\':{\'type\':\'string\'},\'description\':{\'type\':\'string\'},\'owner\':{\'properties\':{\'id\':{\'type\':\'string\'},\'profileUrl\':{\'type\':\'string\'},\'thumbnailUrl\':{\'type\':\'string\'},\'name\':{\'type\':\'string\'}},\'type\':\'object\'},\'video\':{\'$ref\':\'Video\'}},\'type\':\'object\'}',
  'ChiliRelatedListJson': '{\'id\':\'ChiliRelatedListJson\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'items\':{\'items\':{\'$ref\':\'ChiliRelatedResourceJson\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#relatedFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliRelatedResourceJson': '{\'id\':\'ChiliRelatedResourceJson\',\'properties\':{\'summary\':{\'type\':\'any\'},\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'},\'kind\':{\'default\':\'buzz#related\',\'type\':\'string\'}},\'type\':\'object\'}',
  'ChiliVideosListJson': '{\'id\':\'ChiliVideosListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliPhotosResourceJson\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#videosFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
  'Link': '{\'id\':\'Link\',\'properties\':{\'title\':{\'type\':\'string\'},\'height\':{\'type\':\'integer\'},\'count\':{\'type\':\'integer\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'integer\'},\'type\':{\'type\':\'string\'},\'href\':{\'type\':\'string\'}},\'type\':\'object\'}',
  'Video': '{\'id\':\'Video\',\'properties\':{\'duration\':{\'type\':\'integer\'},\'streams\':{\'items\':{\'$ref\':\'Link\'},\'type\':\'array\'},\'size\':{\'type\':\'integer\'}},\'type\':\'object\'}'
 },
 'resources': {
  'activities': {
   'methods': {
    'count': {
     'restPath': 'activities/count',
     'rpcMethod': 'chili.activities.count',
     'httpMethod': 'GET',
     'parameters': {
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesCountJson'
     }
    },
    'delete': {
     'restPath': 'activities/{userId}/{scope}/{postId}',
     'rpcMethod': 'chili.activities.delete',
     'httpMethod': 'DELETE',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'postId': {
       'restParameterType': 'path',
       'pattern': '.*',
       'required': true,
       'repeated': false
      },
      'scope': {
       'restParameterType': 'path',
       'pattern': '@.*',
       'required': true,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     }
    },
    'extractPeopleFromSearch': {
     'restPath': 'activities/search/@people',
     'rpcMethod': 'chili.activities.extractPeopleFromSearch',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'bbox': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lat': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lon': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'pid': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'q': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'radius': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesExtractpeoplefromsearchJson'
     }
    },
    'get': {
     'restPath': 'activities/{userId}/@self/{postId}',
     'rpcMethod': 'chili.activities.get',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'postId': {
       'restParameterType': 'path',
       'pattern': '.*',
       'required': true,
       'repeated': false
      },
      'targetLang': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'truncateAtom': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesResourceJson'
     }
    },
    'insert': {
     'restPath': 'activities/{userId}/@self',
     'rpcMethod': 'chili.activities.insert',
     'httpMethod': 'POST',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'preview': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'request': {
      '$ref': 'ChiliActivitiesResourceJson'
     },
     'response': {
      '$ref': 'ChiliActivitiesResourceJson'
     }
    },
    'list': {
     'restPath': 'activities/{userId}/{scope}',
     'rpcMethod': 'chili.activities.list',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-comments': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-liked': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'scope': {
       'restParameterType': 'path',
       'pattern': '@(self|public|consumption|liked|comments)*',
       'required': true,
       'repeated': false
      },
      'targetLang': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'truncateAtom': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesListJson'
     }
    },
    'search': {
     'restPath': 'activities/search',
     'rpcMethod': 'chili.activities.search',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'bbox': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lat': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lon': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'pid': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'q': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'radius': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'targetLang': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'truncateAtom': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesSearchJson'
     }
    },
    'track': {
     'restPath': 'activities/track',
     'rpcMethod': 'chili.activities.track',
     'httpMethod': 'GET',
     'parameters': {
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'bbox': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'c': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lat': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'lon': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'max-results': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'pid': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'q': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'radius': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      }
     },
     'response': {
      '$ref': 'ChiliActivitiesTrackJson'
     }
    },
    'update': {
     'restPath': 'activities/{userId}/{scope}/{postId}',
     'rpcMethod': 'chili.activities.update',
     'httpMethod': 'PUT',
     'parameters': {
      'abuseType': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'alt': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'hl': {
       'restParameterType': 'query',
       'required': false,
       'repeated': false
      },
      'postId': {
       'restParameterType': 'path',
       'pattern': '.*',
       'required': true,
       'repeated': false
      },
      'scope': {
       'restParameterType': 'path',
       'pattern': '@.*',
       'required': true,
       'repeated': false
      },
      'userId': {
       'restParameterType': 'path',
       'pattern': '[^/]+',
       'required': true,
       'repeated': false
      }
     },
     'request': {
      '$ref': 'ChiliActivitiesResourceJson'
     },
     'response': {
      '$ref': 'ChiliActivitiesResourceJson'
     }
    }
   }
  }
 }
}";
        #endregion
		
		public static void Main (string[] args)
		{
			Logger.Debug("Logging Started");
			//GenerateBuzzServiceV02 ();
			//GenerateAdSenseService ();
			GenerateBuzzServiceV03 ();
			Logger.Debug("All Done");
		}
		
		private static void GenerateBuzzServiceV02 ()
		{
			var serviceName = "buzz";
			var version = "v1";
			var clientNamespace ="Google.Apis.Samples.CommandLineGeneratedService.Buzz";
			var language = "CSharp";
			var output = "../../../CommandLineGeneratedService/Buzz/BuzzService.cs";
			
			GoogleServiceGenerator.GenerateService(serviceName, version, clientNamespace, language, output); 
		}
		
		private static void GenerateBuzzServiceV03 ()
		{
			var version = "v1";
			var clientNamespace ="Google.Apis.Samples.CommandLineGeneratedService.V03.Buzz";
			var language = "CSharp";
			var output = "../../../CommandLineGeneratedService/V03/Buzz/BuzzService.cs";
			
			//var stringFetcher = new StringDiscoveryDevice();
			//stringFetcher.Document = BuzzV0_3_Json;
			
			var cachedFetcher = new CachedWebDiscoveryDevice(
                	new Uri("https://www.googleapis.com/discovery/v0.3/describe/buzz/v1"), 
                    GetCacheDirectory());
			
			var discovery = new DiscoveryService (cachedFetcher);
            // Build the service based on discovery information.
			var param = new FactoryParameterV0_3("http://example.url.com",null);
            var service = discovery.GetService (version, DiscoveryVersion.Version_0_3, param);
            
            var generator = new GoogleServiceGenerator (service, clientNamespace);
            
            var provider = CodeDomProvider.CreateProvider (language);
            
            using (StreamWriter sw = new StreamWriter (output, false)) {
                IndentedTextWriter tw = new IndentedTextWriter (sw, "  ");
                
                // Generate source code using the code provider.
                
                provider.GenerateCodeFromCompileUnit (
					generator.GenerateCode (), tw, new CodeGeneratorOptions ());
                
                // Close the output file.
                tw.Close ();
            }
			
		}
		
		private static DirectoryInfo GetCacheDirectory() 
		{
			string cacheDirectory = Path.Combine (
					Environment.GetFolderPath (Environment.SpecialFolder.ApplicationData), 
			        "GoogleApis.Tools.CodeGenCache");
            if (Directory.Exists (cacheDirectory) == false) {
                Directory.CreateDirectory (cacheDirectory);
            }
			return new DirectoryInfo(cacheDirectory);
		}
		
		private static void GenerateAdSenseService()
		{
			//var serviceName = "adsenseapi";
			var version = "v1beta1";
			var clientNamespace ="Google.Apis.Samples.GeneratedService.AdSense";
			var language = "CSharp";
			var outputFile = "../../../CommandLineGeneratedService/AdSense/AdSenseService.cs";
			
			// Set up how discovery works.
            var webfetcher = new CachedWebDiscoveryDevice (
                                new Uri ("http://elephant.lon:9996/discovery/v0.2beta1/describe/adsense-mgmt/v1beta1"), 
                                GetCacheDirectory());
            var discovery = new DiscoveryService (webfetcher);
            // Build the service based on discovery information.
			var param = new FactoryParameterV0_2("http://elephant.lon:9996",null);
            var service = discovery.GetService (version, DiscoveryVersion.Version_0_2, param);
            
            var generator = new GoogleServiceGenerator (service, clientNamespace);
            
            var provider = CodeDomProvider.CreateProvider (language);
            
            using (StreamWriter sw = new StreamWriter (outputFile, false)) {
                IndentedTextWriter tw = new IndentedTextWriter (sw, "  ");
                
                // Generate source code using the code provider.
                
                provider.GenerateCodeFromCompileUnit (generator.GenerateCode (), tw, new CodeGeneratorOptions ());
                
                // Close the output file.
                tw.Close ();
            }
		}
	}
}

