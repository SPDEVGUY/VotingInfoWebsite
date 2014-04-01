//////////////////////////////////////////////////////////////////////
//Do not modify this file. Make a copy and reference it instead.	//
//////////////////////////////////////////////////////////////////////

/// <reference path="dal.js"/>
/// <reference path="ViewModelBase.js"/>

//Requires dal.js
if (window.dal === undefined) alert('Developer error.  Client.Organizations.viewmodel.js requires dal.js');
//Requires ViewModelBase.js
if (window.dal.ViewModelBaseClass === undefined) alert('Developer error.  Client.Organizations.ViewModelClass.js requires dal.ViewModelBaseClass.js');

//Makes:
//  window.dal.VotingInfo_Client_Organizations_ViewModelClass;

function VotingInfoClientOrganizationsViewModel($, dal, $scope) {
    var _ = $scope || {};
    dal.ViewModelBaseClass(dal, _, "Client", "Organizations");

    
    _.NewItem = function () {
        this._IsNewItem = true;
		this.OrganizationId=0;
		this.ContentInspectionId=0;
		this.OrganizationName="";
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
	_.Exists = function (fldOrganizationId) {
		if(fldOrganizationId===undefined && !(_.CurrentItem.OrganizationId===undefined)) fldOrganizationId = _.CurrentItem.OrganizationId;

		var methodCall = dal.FormatString (
			"Exists({0})"
				,fldOrganizationId
			); 

        _.GetBool(methodCall, _.OnExistsSuccess, _.OnExistsFail);
    };
	_.OnSearchSuccess = _.OnSuccess;
	_.OnSearchFail = _.OnFail;
	_.Search = function (fldOrganizationName, fldSourceUrl) {
		if(fldOrganizationName===undefined && !(_.CurrentItem.OrganizationName===undefined)) fldOrganizationName = _.CurrentItem.OrganizationName;
		if(fldSourceUrl===undefined && !(_.CurrentItem.SourceUrl===undefined)) fldSourceUrl = _.CurrentItem.SourceUrl;

        _.LoadItems("Search()",
			{
				'OrganizationName' : fldOrganizationName,
				'SourceUrl' : fldSourceUrl
			}
			, _.OnSearchSuccess, _.OnSearchFail);
    };
	_.OnSelectBy_OrganizationIdSuccess = _.OnSuccess;
	_.OnSelectBy_OrganizationIdFail = _.OnFail;
	_.SelectBy_OrganizationId = function (fldOrganizationId) {
		if(fldOrganizationId===undefined && !(_.CurrentItem.OrganizationId===undefined)) fldOrganizationId = _.CurrentItem.OrganizationId;

        _.LoadItems("SelectBy_OrganizationId()",
			{
				'OrganizationId' : fldOrganizationId
			}
			, _.OnSelectBy_OrganizationIdSuccess, _.OnSelectBy_OrganizationIdFail);
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