//////////////////////////////////////////////////////////////////////
//Do not modify this file. Make a copy and reference it instead.	//
//////////////////////////////////////////////////////////////////////

/// <reference path="dal.js"/>
/// <reference path="ViewModelBase.js"/>

//Requires dal.js
if (window.dal === undefined) alert('Developer error.  Client.Locations.viewmodel.js requires dal.js');
//Requires ViewModelBase.js
if (window.dal.ViewModelBaseClass === undefined) alert('Developer error.  Client.Locations.ViewModelClass.js requires dal.ViewModelBaseClass.js');

//Makes:
//  window.dal.VotingInfo_Client_Locations_ViewModelClass;

function VotingInfoClientLocationsViewModel($, dal, $scope) {
    var _ = $scope || {};
    dal.ViewModelBaseClass(dal, _, "Client", "Locations");

    
    _.NewItem = function () {
        this._IsNewItem = true;
		this.LocationId=0;
		this.ContentInspectionId=0;
		this.LocationName="";
		this.IsArchived=false;
		this.IsBeingProposed=false;
		this.ProposedByUserId=0;
		this.ConfirmedByUserId=0;
		this.FalseInfoCount=0;
		this.TrueInfoCount=0;
		this.AdminInpsected=false;
		this.DateLastChecked=Date();
		this.SourceUrl="";

    };
    
	_.OnExistsSuccess = function (viewModel, result) { };
	_.OnExistsFail = _.OnFail;
	_.Exists = function (fldLocationId) {
		if(fldLocationId===undefined && !(_.CurrentItem.LocationId===undefined)) fldLocationId = _.CurrentItem.LocationId;

		var methodCall = dal.FormatString (
			"Exists({0})"
				,fldLocationId
			); 

        _.GetBool(methodCall, _.OnExistsSuccess, _.OnExistsFail);
    };
	_.OnSearchSuccess = _.OnSuccess;
	_.OnSearchFail = _.OnFail;
	_.Search = function (fldLocationName, fldSourceUrl) {
		if(fldLocationName===undefined && !(_.CurrentItem.LocationName===undefined)) fldLocationName = _.CurrentItem.LocationName;
		if(fldSourceUrl===undefined && !(_.CurrentItem.SourceUrl===undefined)) fldSourceUrl = _.CurrentItem.SourceUrl;

        _.LoadItems("Search()",
			{
				'LocationName' : fldLocationName,
				'SourceUrl' : fldSourceUrl
			}
			, _.OnSearchSuccess, _.OnSearchFail);
    };
	_.OnSelectBy_LocationIdSuccess = _.OnSuccess;
	_.OnSelectBy_LocationIdFail = _.OnFail;
	_.SelectBy_LocationId = function (fldLocationId) {
		if(fldLocationId===undefined && !(_.CurrentItem.LocationId===undefined)) fldLocationId = _.CurrentItem.LocationId;

        _.LoadItems("SelectBy_LocationId()",
			{
				'LocationId' : fldLocationId
			}
			, _.OnSelectBy_LocationIdSuccess, _.OnSelectBy_LocationIdFail);
    };
	_.OnSelectBy_ContentInspectionIdSuccess = _.OnSuccess;
	_.OnSelectBy_ContentInspectionIdFail = _.OnFail;
	_.SelectBy_ContentInspectionId = function (fldContentInspectionId) {
		if(fldContentInspectionId===undefined && !(_.CurrentItem.ContentInspectionId===undefined)) fldContentInspectionId = _.CurrentItem.ContentInspectionId;

        _.LoadItems("SelectBy_ContentInspectionId()",
			{
				'ContentInspectionId' : fldContentInspectionId
			}
			, _.OnSelectBy_ContentInspectionIdSuccess, _.OnSelectBy_ContentInspectionIdFail);
    };
	_.OnSelectBy_ProposedByUserIdSuccess = _.OnSuccess;
	_.OnSelectBy_ProposedByUserIdFail = _.OnFail;
	_.SelectBy_ProposedByUserId = function (fldProposedByUserId) {
		if(fldProposedByUserId===undefined && !(_.CurrentItem.ProposedByUserId===undefined)) fldProposedByUserId = _.CurrentItem.ProposedByUserId;

        _.LoadItems("SelectBy_ProposedByUserId()",
			{
				'ProposedByUserId' : fldProposedByUserId
			}
			, _.OnSelectBy_ProposedByUserIdSuccess, _.OnSelectBy_ProposedByUserIdFail);
    };
	_.OnSelectBy_ConfirmedByUserIdSuccess = _.OnSuccess;
	_.OnSelectBy_ConfirmedByUserIdFail = _.OnFail;
	_.SelectBy_ConfirmedByUserId = function (fldConfirmedByUserId) {
		if(fldConfirmedByUserId===undefined && !(_.CurrentItem.ConfirmedByUserId===undefined)) fldConfirmedByUserId = _.CurrentItem.ConfirmedByUserId;

        _.LoadItems("SelectBy_ConfirmedByUserId()",
			{
				'ConfirmedByUserId' : fldConfirmedByUserId
			}
			, _.OnSelectBy_ConfirmedByUserIdSuccess, _.OnSelectBy_ConfirmedByUserIdFail);
    };


    return _;
};